using Knowledge.Core.Chemical;
using Knowledge.Entities.Chemicals;

namespace Knowledge.Business;

public class JsonFileChemicalRepository : IChemicalRepository
{
    private string basedFolder = Path.GetTempPath();

    private readonly string COMPOUND_FILE = "Chemical_Compounds.json";
    private readonly string RULE_FILE = "Chemical_Rules.json";

    private List<T> ReadFile<T>(string fileName)
    {
        var fullPath = Path.Combine(basedFolder, fileName);

        var result = new List<T>();
        if (File.Exists(fullPath))
        {
            return System.Text.Json.JsonSerializer.Deserialize<List<T>>(File.ReadAllText(fullPath)) ?? result;
        }
        return result;
    }

    private void SaveFile<T>(string fileName, List<T> values)
    {
        var fullPath = Path.Combine(basedFolder, fileName);

        var json = System.Text.Json.JsonSerializer.Serialize(values);
        var dir = Path.GetDirectoryName(fullPath);
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir!);
        }

        File.WriteAllText(fullPath, json);
    }

    public Task<long> CreateNewCompound(string? name, Dictionary<Atom, int> formulaDetails, Dictionary<string, string>? properties = null)
    {
        var existCompounds = ReadFile<Chemical_Compound>(COMPOUND_FILE);

        var newId = IdGenerator.NewId();
        var details = formulaDetails.Select(x => new Chemical_FormulaDetail
        {
            CompoundId = newId,
            Atom = x.Key,
            AtomWeight = x.Value,
        }).ToList();

        var compoundProperties = properties?.Select(x => new Chemical_CompoundProperty { Name = x.Key, Value = x.Value }).ToList();

        var newCompound = new Chemical_Compound()
        {
            Id = newId,
            Name = name,
            FormulaDetails = details,
            Properties = compoundProperties,
            IsDeleted = false,
        };

        existCompounds.Add(newCompound);

        SaveFile(COMPOUND_FILE, existCompounds);

        return Task.FromResult(newId);
    }

    public Task<long> CreateNewRule(Dictionary<long, int> reactants, Dictionary<long, int> conclusions)
    {
        var existRules = ReadFile<Chemical_Rule>(RULE_FILE);
        var existCompounds = ReadFile<Chemical_Compound>(COMPOUND_FILE);

        var newId = IdGenerator.NewId();

        var items = new List<Chemical_RuleItem>();

        foreach (var reactant in reactants)
        {
            items.Add(new Chemical_RuleItem
            {
                CompoundId = reactant.Key,
                RuleId = newId,
                RuleType = RuleType.Reactant,
                MoleWeight = reactant.Value,
            });
        }

        foreach (var conclusion in conclusions)
        {
            items.Add(new Chemical_RuleItem
            {
                CompoundId = conclusion.Key,
                RuleId = newId,
                RuleType = RuleType.Conclusion,
                MoleWeight = conclusion.Value,
            });
        }

        var newRule = new Chemical_Rule
        {
            Id = newId,
            Display = BuildRuleDisplay(reactants, conclusions, existCompounds),
            Items = items,
            IsDeleted = false,
        };

        existRules.Add(newRule);

        SaveFile(RULE_FILE, existRules);

        return Task.FromResult(newId);
    }

    private string BuildRuleDisplay(Dictionary<long, int> reactants, Dictionary<long, int> conclusions, IList<Chemical_Compound> compounds)
    {
        var leftEles = reactants.Select(x => FormatRuleEle(x.Key, x.Value, compounds));
        var rightEles = conclusions.Select(x => FormatRuleEle(x.Key, x.Value, compounds));

        return $"{string.Join(" + ", leftEles)} -> {string.Join(" + ", rightEles)}";
    }

    private string FormatRuleEle(long compoundId, int moles, IList<Chemical_Compound> compounds)
    {
        var compound = compounds.FirstOrDefault(x => x.Id == compoundId)
            ?? throw new Exception($"Not exist compound {compoundId}");

        var compoundName = compound.Name ?? BuildCompoundName(compound.FormulaDetails);

        return $"{(moles != 1 ? moles : "")}{compoundName}";
    }

    private string BuildCompoundName(IList<Chemical_FormulaDetail> formulaDetails)
    {
        var elements = formulaDetails.Select(x => $"{x.Atom}{(x.AtomWeight != 1 ? x.AtomWeight : "")}");
        return string.Join("", elements);
    }

    public Task<Chemical_Compound?> FindCompound(long compoundId)
    {
        var exitCompounds = ReadFile<Chemical_Compound>(COMPOUND_FILE);

        return Task.FromResult(exitCompounds.FirstOrDefault(x => x.Id == compoundId));
    }

    public async Task<IList<Chemical_Rule>> FindRuleFromAtoms(IList<Atom> atoms)
    {
        var exitCompounds = ReadFile<Chemical_Compound>(COMPOUND_FILE);
        var exitRules = ReadFile<Chemical_Rule>(RULE_FILE);

        var result = new List<Chemical_Rule>();
        foreach (var rule in exitRules)
        {
            var ruleAtoms = GetRuleAtoms(rule, exitCompounds);

            if (ruleAtoms.All(atoms.Contains))
            {
                result.Add(rule);
            }
        }

        return result;
    }

    private IList<Atom> GetRuleAtoms(Chemical_Rule rule, IList<Chemical_Compound> compounds)
    {
        var result = new List<Atom>();

        foreach (var ruleItem in rule.Items.Where(x => x.RuleType == RuleType.Reactant))
        {
            var compound = compounds.FirstOrDefault(x => x.Id == ruleItem.CompoundId);

            if (compound == null) continue;

            foreach (var formulaDetail in compound.FormulaDetails)
            {
                if (!result.Contains(formulaDetail.Atom))
                {
                    result.Add(formulaDetail.Atom);
                }
            }
        }

        return result;
    }

    public async Task<IList<Chemical_Compound>> GetAvailableCompounds()
    {
        return ReadFile<Chemical_Compound>(COMPOUND_FILE);
    }

    public async Task<IList<Chemical_Rule>> GetAvailableRules()
    {
        return ReadFile<Chemical_Rule>(RULE_FILE);
    }
}
