using Knowledge.Core;

namespace Knowledge.Triangle.Formulas;

class HerongFomula : IFormula<TriangleElementType>
{
    public string Display => "S = √[(p-a).(p-b).(p-c)]";
    public string? Description => "Công thức Heron dùng để tính diện tích tam giác khi biết độ dài các cạnh:" +
        "\tp: nửa chu vi " +
        "\ra,b,c: độ dài 3 cạnh";
    public IList<TriangleElementType> FormulaElements =>
        new List<TriangleElementType>
        {
            TriangleElementType.a_Edge,
            TriangleElementType.b_Edge,
            TriangleElementType.c_Edge,
            TriangleElementType.p,
            TriangleElementType.S
        };

    public Task Inference(IList<Element<TriangleElementType>> elements)
    {
        if (elements.Any(x => !FormulaElements.Contains(x.Type)))
        {
            return Task.CompletedTask;
        }

        // TODO somethings
        throw new NotImplementedException();
    }
}
