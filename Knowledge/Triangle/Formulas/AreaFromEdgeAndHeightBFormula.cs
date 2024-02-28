using Knowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Triangle.Formulas;

class AreaFromEdgeAndHeightBFormula : IFormula<TriangleElementType>
{
    public string Display => "S = 1/2 b.Hb";

    public string? Description => throw new NotImplementedException();

    public IList<TriangleElementType> FormulaElements => new List<TriangleElementType>
    {
        TriangleElementType.S,
        TriangleElementType.b_Edge,
        TriangleElementType.hB,
    };

    public Task Inference(IList<Element<TriangleElementType>> elements)
    {
        throw new NotImplementedException();
    }
}
