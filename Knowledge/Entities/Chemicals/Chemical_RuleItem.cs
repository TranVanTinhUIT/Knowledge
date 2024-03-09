using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledge.Entities.Chemicals;

[Table("RuleItems", Schema ="chemical")]
public class Chemical_RuleItem
{
    public long RuleId { get; set; }

    public long CompoundId { get; set; }

    public RuleType RuleType { get; set; }

    public int MoleWeight { get; set; }
}

public enum RuleType
{
    Reactant = 1,
    Conclusion = 2
}