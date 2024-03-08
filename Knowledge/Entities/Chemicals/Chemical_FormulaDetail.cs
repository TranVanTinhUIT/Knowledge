using Knowledge.Core.Chemical;
using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledge.Entities.Chemicals;

[Table("FormulaDetails", Schema = "chemical")]
public class Chemical_FormulaDetail
{
    public long CompoundId { get; set; }

    public Atom Atom { get; set; }

    public int AtomWeight { get; set; } = default!;
}
