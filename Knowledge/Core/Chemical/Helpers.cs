using Knowledge.Entities.Chemicals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Core.Chemical;

public static class Helpers
{
    public static string BuildCompoundName(IList<Chemical_FormulaDetail> formulaDetails)
    {
        var elements = formulaDetails.Select(x => $"{x.Atom}{(x.AtomWeight != 1 ? x.AtomWeight : "")}");
        return string.Join("", elements);
    }

    public static string BuildRuleName(IList<Chemical_RuleItem> items, IList<Chemical_Compound> compounds)
    {
        var leftEles = items.Where(x => x.RuleType == RuleType.Reactant).Select(x => FormatRuleEle(x.CompoundId, x.MoleWeight, compounds));
        var rightEles = items.Where(x => x.RuleType == RuleType.Conclusion).Select(x => FormatRuleEle(x.CompoundId, x.MoleWeight, compounds));

        return $"{string.Join(" + ", leftEles)} -> {string.Join(" + ", rightEles)}";
    }

    public static string FormatRuleEle(long compoundId, int moles, IList<Chemical_Compound> compounds)
    {
        var compound = compounds.FirstOrDefault(x => x.Id == compoundId)
            ?? throw new Exception($"Not exist compound {compoundId}");

        var compoundName = compound.Name;

        return $"{(moles != 1 ? moles : "")}{compoundName}";
    }

    public static IList<Chemical_RuleItem> BuildRuleItems(Dictionary<long, int> reactants, Dictionary<long, int> conclusions)
    {
        var result = new List<Chemical_RuleItem>();

        foreach (var reactant in reactants)
        {
            result.Add(new Chemical_RuleItem
            {
                CompoundId = reactant.Key,
                MoleWeight = reactant.Value,
                RuleType = RuleType.Reactant
            });
        }
        foreach (var conclusion in conclusions)
        {
            result.Add(new Chemical_RuleItem
            {
                CompoundId = conclusion.Key,
                MoleWeight = conclusion.Value,
                RuleType = RuleType.Conclusion
            });
        }
        return result;
    }
}
