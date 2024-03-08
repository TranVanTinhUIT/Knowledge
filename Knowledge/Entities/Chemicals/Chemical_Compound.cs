using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledge.Entities.Chemicals;

[Table("Compounds", Schema = "chemical")]
public class Chemical_Compound
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public IList<Chemical_FormulaDetail> FormulaDetails { get; set; } = default!;

    public IList<Chemical_CompoundProperty>? Properties { get; set; }

    public bool IsDeleted { get; set; }
}
