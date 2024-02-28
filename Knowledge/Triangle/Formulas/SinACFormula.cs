using Knowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Triangle.Formulas;

class SinACFormula : IFormula<TriangleElementType>
{
    public string Display => "a/sinA = c/sinC";

    public string? Description => "Trong tam giác ABC bất kỳ, tỉ số giữa một cạnh và sin của góc đối diện với cạnh đó.";

    public IList<TriangleElementType> FormulaElements => new List<TriangleElementType>()
    {
        TriangleElementType.a_Edge,
        TriangleElementType.A_corner,
        TriangleElementType.c_Edge,
        TriangleElementType.C_corner,
    };

    public Task Inference(IList<Element<TriangleElementType>> elements)
    {
        throw new NotImplementedException();
    }
}
