using Knowledge.Core.Chemical;
using Knowledge.Entities.Chemicals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Business.Chemical;

public class RuleBasedSystem
{
    private readonly IChemicalRepository _chemicalRepository;
    private bool IsInitnowledge = false;
    public RuleBasedSystem(IChemicalRepository chemicalRepository)
    {
        this._chemicalRepository = chemicalRepository;
    }

    private async Task InitKnowledge()
    {
        if (IsInitnowledge) return;

        // Initial chemical compound
        var S_ID = await _chemicalRepository.CreateNewCompound("S", new Dictionary<Atom, int> { { Atom.S, 1 } });
        var Na_ID = await _chemicalRepository.CreateNewCompound("Na", new Dictionary<Atom, int> { { Atom.Na, 1 } });
        var O2_ID = await _chemicalRepository.CreateNewCompound("O2", new Dictionary<Atom, int> { { Atom.O, 2 } });
        var H2_ID = await _chemicalRepository.CreateNewCompound("H2", new Dictionary<Atom, int> { { Atom.H, 2 } });
        var Cl2_ID = await _chemicalRepository.CreateNewCompound("Cl2", new Dictionary<Atom, int> { { Atom.Cl, 2 } });
        var SO2_ID = await _chemicalRepository.CreateNewCompound("SO2", new Dictionary<Atom, int> { { Atom.S, 1 }, { Atom.O, 2 } });
        var SO3_ID = await _chemicalRepository.CreateNewCompound("SO3", new Dictionary<Atom, int> { { Atom.S, 1 }, { Atom.O, 3 } });
        var H2O_ID = await _chemicalRepository.CreateNewCompound("H2O", new Dictionary<Atom, int> { { Atom.H, 2 }, { Atom.O, 1 } });
        var H2SO4_ID = await _chemicalRepository.CreateNewCompound("H2SO4", new Dictionary<Atom, int> { { Atom.H, 2 }, { Atom.S, 1 }, { Atom.O, 4 } });
        var NaCl_ID = await _chemicalRepository.CreateNewCompound("NaCl", new Dictionary<Atom, int> { { Atom.Na, 1 }, { Atom.Cl, 1 }});
        var Na2SO4_ID = await _chemicalRepository.CreateNewCompound("Na2SO4", new Dictionary<Atom, int> { { Atom.Na, 2 }, { Atom.S, 1 }, { Atom.O, 4 } });
        var HCl_ID = await _chemicalRepository.CreateNewCompound("HCl", new Dictionary<Atom, int> { { Atom.H, 1 }, { Atom.Cl, 1 }});
        var HClO_ID = await _chemicalRepository.CreateNewCompound("HClO", new Dictionary<Atom, int> { { Atom.H, 1 }, { Atom.Cl, 1 }, { Atom.O, 1 } });
        var NaOH_ID = await _chemicalRepository.CreateNewCompound("NaOH", new Dictionary<Atom, int> { { Atom.Na, 1 }, { Atom.O, 1 }, { Atom.H, 1 } });

        // Initial rule

        // 2Na + Cl2 -> 2NaCl
        await _chemicalRepository.CreateNewRule(
        new Dictionary<long, int>
        {
            { Na_ID, 2 },
            { Cl2_ID, 1 }
        },
        new Dictionary<long, int>
        {
            { NaCl_ID, 2 }
        }
        );

        // Cl2 + H2O -> HCl + HClO
        await _chemicalRepository.CreateNewRule(
        new Dictionary<long, int>
        {
            { Cl2_ID, 1 },
            { H2O_ID, 1 },
        },
        new Dictionary<long, int>
        {
            { HCl_ID, 1 },
            { HClO_ID, 1 },
        }
        );

        // 2NaCl + 2H2O -> Cl2 + H2 + 2NaOH
        await _chemicalRepository.CreateNewRule(
        new Dictionary<long, int>
        {
            { NaCl_ID, 2 },
            { H2O_ID, 2 },
        },
        new Dictionary<long, int>
        {
            { Cl2_ID, 1 },
            { H2_ID, 1 },
            { NaOH_ID, 2 },
        }
        );

        // S + O2 -> SO2
        await _chemicalRepository.CreateNewRule(
        new Dictionary<long, int>
        {
            { S_ID, 1 },
            { O2_ID, 1 },
        },
        new Dictionary<long, int>
        {
            { SO2_ID, 1 },
        }
        );

        // 2SO2 + O2 -> 2SO3
        await _chemicalRepository.CreateNewRule(
        new Dictionary<long, int>
        {
            { SO2_ID, 2 },
            { O2_ID, 1 },
        },
        new Dictionary<long, int>
        {
            { SO3_ID, 2 },
        }
        );

        // SO3 + H2O -> H2SO4
        await _chemicalRepository.CreateNewRule(
        new Dictionary<long, int>
        {
            { SO3_ID, 1 },
            { H2O_ID, 1 },
        },
        new Dictionary<long, int>
        {
            { H2SO4_ID, 2 },
        }
        );

        // 2NaCl + H2SO4 -> Na2SO4 + 2HCl
        await _chemicalRepository.CreateNewRule(
        new Dictionary<long, int>
        {
            { NaCl_ID, 2 },
            { H2SO4_ID, 1 },
        },
        new Dictionary<long, int>
        {
            { Na2SO4_ID, 1 },
            { HCl_ID, 2 },
        }
        );

        // 2NaOH -> 2Na + H2O + O2
        await _chemicalRepository.CreateNewRule(
        new Dictionary<long, int>
        {
            { NaOH_ID, 2 },
        },
        new Dictionary<long, int>
        {
            { Na_ID, 2 },
            { H2O_ID, 1 },
            { O2_ID, 1 },
        }
        );

        IsInitnowledge = true;
    }

    public async Task<IList<Chemical_Rule>> ForwardChaining(IList<long> initCompoundIds, IList<long> targetCompoundIds)
    {
        throw new NotImplementedException();
    }
}
