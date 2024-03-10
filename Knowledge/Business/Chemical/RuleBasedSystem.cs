using Knowledge.Core.Chemical;
using Knowledge.Entities.Chemicals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Business.Chemical;

public class RuleBasedSystem
{
    private readonly IChemicalRepositoryFactory _factory;
    public RuleBasedSystem(IChemicalRepositoryFactory factory)
    {
        this._factory = factory;
    }

    public async Task<IList<Chemical_Rule>?> BackwardChaining(IList<long> initCompoundIds, IList<long> targetCompoundIds)
    {
        var repositoty = _factory.CreateChemicalRepository("jsonFile");
        var compounds = await repositoty.GetAvailableCompounds();
        var atoms = GetAtoms(initCompoundIds, compounds);

        var relatedRules = await repositoty.FindRuleFromAtoms(atoms);

        var usedRuleIds = new List<long>();
        var compoundInfoDicts = targetCompoundIds.ToDictionary(x => x, x => false);
        var path = BackwardSearchRules(initCompoundIds, compoundInfoDicts, usedRuleIds, relatedRules);

        if (path == null) { return null; }

        var resultRules = path.Reverse().Select(ruleId => relatedRules.First(rule => rule.Id == ruleId)).ToList();

        return resultRules;
    }

    public async Task<IList<Chemical_Rule>?> ForwardChaining(IList<long> initCompoundIds, IList<long> targetCompoundIds)
    {
        var repositoty = _factory.CreateChemicalRepository("jsonFile");
        var compounds = await repositoty.GetAvailableCompounds();
        var atoms = GetAtoms(initCompoundIds, compounds);

        var relatedRules = await repositoty.FindRuleFromAtoms(atoms);

        var exitingCompounds = new List<long>(initCompoundIds);

        var usedRules = new List<long>();

        var path = ForwardSearchRules(initCompoundIds, targetCompoundIds, usedRules, relatedRules);

        if (path == null) { return null; }

        var resultRules = path.Select(ruleId => relatedRules.First(rule => rule.Id == ruleId)).ToList();

        return resultRules;
    }

    private IList<long>? ForwardSearchRules(IList<long> exitingCompoundIds, IList<long> targetCompoundIds, IList<long> usedRuleIds, IList<Chemical_Rule> allRules)
    {
        if (targetCompoundIds.All(x => exitingCompoundIds.Contains(x))) 
        { return usedRuleIds; }

        var paths = new List<IList<long>>();

        foreach (var rule in allRules.Where(rule => !usedRuleIds.Contains(rule.Id))) // Chỉ xét những luật chưa được áp dụng
        {
            var reactantCompoundIds = rule.Items.Where(x => x.RuleType == RuleType.Reactant).Select(x => x.CompoundId);

            if (reactantCompoundIds.Any(reactantCompoundId => exitingCompoundIds.Contains(reactantCompoundId))) 
            {
                var newExitingCompoundIds = new List<long>(exitingCompoundIds);
                foreach (var conclusionCompoundId in rule.Items.Where(item => item.RuleType == RuleType.Conclusion).Select(x => x.CompoundId))
                {
                    if (!newExitingCompoundIds.Contains(conclusionCompoundId))
                    {
                        newExitingCompoundIds.Add(conclusionCompoundId);
                    }
                }

                var newUsedRules = new List<long>(usedRuleIds);
                newUsedRules.Add(rule.Id);

                var path = ForwardSearchRules(newExitingCompoundIds, targetCompoundIds, newUsedRules, allRules);

                if (path != null)
                {
                    paths.Add(path);
                }
            }
        }

        if (paths.Count == 0)
        {
            return null;
        }

        return paths.OrderBy(path => path.Count).First();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initCompoundIds"></param>
    /// <param name="compoundInfoDicts">Key: compound id, value: true if compound is known</param>
    /// <param name="allRules"></param>
    /// <param name="usedRuleIds">reserve rule path to resolve</param>
    /// <returns></returns>
    private IList<long>? BackwardSearchRules(IList<long> initCompoundIds, Dictionary<long, bool> compoundInfoDicts, IList<long> usedRuleIds, IList<Chemical_Rule> allRules)
    {
        if (compoundInfoDicts.All(x => x.Value)) // If all compounds are known
        {
            return usedRuleIds;
        }

        var paths = new List<IList<long>>();

        var unknowCompoundIds = compoundInfoDicts.Where(x => !x.Value).Select(x => x.Key).ToList(); // Get unknow compounds

        foreach (var rule in allRules.Where(rule => !usedRuleIds.Contains(rule.Id))) // Only get unused rules
        {
            var conclusionCompoundIds = rule.Items.Where(item => item.RuleType == RuleType.Conclusion).Select(x => x.CompoundId);

            if (conclusionCompoundIds.Any(x => unknowCompoundIds.Contains(x))) // nếu Rule có chất sản phẩm nằm trong tập các chất chưa biết
            {
                var newCompoundInfoDicts = new Dictionary<long, bool>(compoundInfoDicts);
                foreach (var conclusionCompoundId in conclusionCompoundIds)
                {
                    if (newCompoundInfoDicts.ContainsKey(conclusionCompoundId))
                    {
                        newCompoundInfoDicts[conclusionCompoundId] = true;
                    }
                }
                foreach (var reactant in rule.Items.Where(x => x.RuleType == RuleType.Reactant))
                {
                    if (!newCompoundInfoDicts.ContainsKey(reactant.CompoundId))
                    {
                        newCompoundInfoDicts.Add(reactant.CompoundId, initCompoundIds.Contains(reactant.CompoundId));
                    }
                }

                var newUsedRules = new List<long>(usedRuleIds);
                newUsedRules.Add(rule.Id);

                var path = BackwardSearchRules(initCompoundIds, newCompoundInfoDicts, newUsedRules, allRules);

                if (path != null)
                {
                    paths.Add(path);
                }
            }
        }

        if (paths.Count == 0)
        {
            return null;
        }

        return paths.OrderBy(path => path.Count).First();
    }

    private IList<Atom> GetAtoms(IList<long> initCompoundIds, IList<Chemical_Compound> compounds)
    {
        var result = new List<Atom>();
        foreach (var compoundId in initCompoundIds)
        {
            var compound = compounds.FirstOrDefault(x => x.Id == compoundId);
            if (compound == null) continue;

            foreach (var formula in compound.FormulaDetails)
            {
                if (!result.Contains(formula.Atom))
                {
                    result.Add(formula.Atom);
                }
            }

        }
        return result;
    }
}