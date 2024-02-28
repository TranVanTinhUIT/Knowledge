using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Knowledge.Core;
using Knowledge.Triangle.Formulas;

namespace Knowledge.Triangle;

public class TriangleMain
{
    private static List<IFormula<TriangleElementType>> _formulas = new List<IFormula<TriangleElementType>>();
    private List<Element<TriangleElementType>> _Element = new List<Element<TriangleElementType>>();

    public TriangleMain()
    {
        BuildKnowledgeBase();
    }

    private void BuildKnowledgeBase()
    {
        _formulas.Clear();
        _formulas.Add(new AreaFromEdgeAndHeightAFormula());
        _formulas.Add(new AreaFromEdgeAndHeightBFormula());
        _formulas.Add(new AreaFromEdgeAndHeightCFormula());
        _formulas.Add(new AreaFromEdgeAndSinAFormula());
        _formulas.Add(new AreaFromEdgeAndSinBFormula());
        _formulas.Add(new AreaFromEdgeAndSinCFormula());
        _formulas.Add(new CosinAFormula());
        _formulas.Add(new CosinBFormula());
        _formulas.Add(new CosinCFormula());
        _formulas.Add(new HerongFomula());
        _formulas.Add(new SinABFormula());
        _formulas.Add(new SinACFormula());
        _formulas.Add(new SinBCFormula());
        _formulas.Add(new SumCornersFormula());
    }

    public Dictionary<TriangleElementType, string> GetElements()
    {
        return _Element.ToDictionary(x => x.Type, x => x.Label?? x.Type.ToString());
    }

    public IList<TriangleFormulaInfo> GetFormulaInfos()
    {
        return _formulas.Select(x => new TriangleFormulaInfo
        {
            Display = x.Display,
            Description = x.Description,
            DependencyElements = x.FormulaElements
        }).ToList();
    }
}

public class TriangleFormulaInfo
{
    public string Display { get; set; } = default!;

    public string? Description { get; set; } = default!;

    public IList<TriangleElementType> DependencyElements { get; set; } = default!;
}