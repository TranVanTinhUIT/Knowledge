using Knowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Triangle.Formulas;

class SinABFormula : IFormula<TriangleElementType>
{
    public string Display => "a/sinA = b/sinB";

    public string? Description => "Trong tam giác ABC bất kỳ, tỉ số giữa một cạnh và sin của góc đối diện với cạnh đó.";

    public IList<TriangleElementType> FormulaElements => new List<TriangleElementType>()
    {
        TriangleElementType.a_Edge,
        TriangleElementType.A_corner,
        TriangleElementType.b_Edge,
        TriangleElementType.B_corner,
    };

    public Task Inference(IList<Element<TriangleElementType>> elements)
    {
        throw new NotImplementedException();
    }
}
