using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Core.Chemical;

public interface IChemicalRepositoryFactory
{
    public IChemicalRepository CreateChemicalRepository(string name);
}
