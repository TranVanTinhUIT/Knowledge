using System.ComponentModel.DataAnnotations.Schema;

namespace Knowledge.Entities.Chemicals;

[Table("CompoundProperties", Schema ="chemical")]
public class Chemical_CompoundProperty
{
    public long CompoundId { get; set; }

    public string Name { get; set; } = default!;

    public string Value { get; set; } = default!;
}
