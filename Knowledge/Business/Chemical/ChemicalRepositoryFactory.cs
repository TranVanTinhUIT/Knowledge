using Knowledge.Core.Chemical;

namespace Knowledge.Business.Chemical;

public class ChemicalRepositoryFactory : IChemicalRepositoryFactory
{
    public IChemicalRepository CreateChemicalRepository(string name)
    {
        return new JsonFileChemicalRepository();
    }
}
