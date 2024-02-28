using Knowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Triangle.Formulas;

class AreaFromEdgeAndHeightAFormula : IFormula<TriangleElementType>
{
    public string Display => "S = 1/2 a.Ha";

    public string? Description => throw new NotImplementedException();

    public IList<TriangleElementType> FormulaElements => new List<TriangleElementType>
    {
        TriangleElementType.S,
        TriangleElementType.a_Edge,
        TriangleElementType.hA,
    };

    public Task Inference(IList<Element<TriangleElementType>> elements)
    {
        throw new NotImplementedException();
    }
}
