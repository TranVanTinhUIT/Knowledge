using Knowledge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Triangle.Formulas;

class CosinAFormula : IFormula<TriangleElementType>
{
    public string Display => "cosA = (b^2 + c^2 - a^2)/ 2bc";

    public string? Description => "Trong một tam giác bất kì, " +
        "bình phương một cạnh bằng tổng các bình phương của hai cạnh còn lại trừ đi hai lần tích của hai cạnh đó nhân với COS của góc xen giữa chúng.";

    public IList<TriangleElementType> FormulaElements => new List<TriangleElementType>()
    {
        TriangleElementType.a_Edge,
        TriangleElementType.b_Edge,
        TriangleElementType.c_Edge,
        TriangleElementType.A_corner,
    };

    public Task Inference(IList<Element<TriangleElementType>> elements)
    {
        throw new NotImplementedException();
    }
}
