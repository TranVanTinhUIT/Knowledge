using Knowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Triangle.Formulas;

class AreaFromEdgeAndSinAFormula : IFormula<TriangleElementType>
{
    public string Display => "S = 1/2 b.c.SinA";

    public string? Description => throw new NotImplementedException();

    public IList<TriangleElementType> FormulaElements => new List<TriangleElementType>
    {
        TriangleElementType.S,
        TriangleElementType.b_Edge,
        TriangleElementType.c_Edge,
        TriangleElementType.A_corner,
    };

    public Task Inference(IList<Element<TriangleElementType>> elements)
    {
        throw new NotImplementedException();
    }
}
