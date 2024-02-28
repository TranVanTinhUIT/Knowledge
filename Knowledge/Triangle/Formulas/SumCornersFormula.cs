using Knowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Triangle.Formulas;

class SumCornersFormula : IFormula<TriangleElementType>
{
    public string Display => "A + B + C = Pi (π)";

    public string? Description => "Tổng 3 góc của 1 tam giác luôn bằng Pi (π)";

    public IList<TriangleElementType> FormulaElements => new List<TriangleElementType>
    {
        TriangleElementType.A_corner,
        TriangleElementType.B_corner,
        TriangleElementType.C_corner,
    };

    public Task Inference(IList<Element<TriangleElementType>> elements)
    {
        throw new NotImplementedException();
    }
}
