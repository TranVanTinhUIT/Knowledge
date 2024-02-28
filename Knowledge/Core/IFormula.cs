namespace Knowledge.Core;

public interface IFormula<T> where T : Enum
{
    public string Display { get; }

    public string? Description { get; }

    public IList<T> FormulaElements { get; }

    public Task Inference(IList<Element<T>> elements);
}

public class Element<T> where T : Enum
{
    public T Type { get; set; } = default!;

    public string? Label { get; set; }

    public string? Value { get; set; }
}