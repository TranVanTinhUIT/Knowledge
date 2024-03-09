using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Entities.Chemicals;

[Table("Rules", Schema ="chemical")]
public class Chemical_Rule
{
    public long Id { get; set; }

    public string Name { get; set; } = default!;

    public IList<Chemical_RuleItem> Items { get; set; } = default!;

    public bool IsDeleted { get; set; }
}
