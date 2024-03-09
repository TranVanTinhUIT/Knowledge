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
    private readonly IChemicalRepositoryFactory _factory;
    private bool IsInitnowledge = false;
    public RuleBasedSystem(IChemicalRepositoryFactory factory)
    {
        this._factory = factory;
    }

    private async Task InitKnowledge()
    {
        if (IsInitnowledge) return;

        var repositoty = _factory.CreateChemicalRepository("jsonFile");

        // Initial chemical compound
        var S_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.S, 1 } });
        var Na_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.Na, 1 } });
        var O2_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.O, 2 } });
        var H2_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.H, 2 } });
        var Cl2_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.Cl, 2 } });
        var SO2_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.S, 1 }, { Atom.O, 2 } });
        var SO3_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.S, 1 }, { Atom.O, 3 } });
        var H2O_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.H, 2 }, { Atom.O, 1 } });
        var H2SO4_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.H, 2 }, { Atom.S, 1 }, { Atom.O, 4 } });
        var NaCl_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.Na, 1 }, { Atom.Cl, 1 }});
        var Na2SO4_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.Na, 2 }, { Atom.S, 1 }, { Atom.O, 4 } });
        var HCl_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.H, 1 }, { Atom.Cl, 1 }});
        var HClO_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.H, 1 }, { Atom.Cl, 1 }, { Atom.O, 1 } });
        var NaOH_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.Na, 1 }, { Atom.O, 1 }, { Atom.H, 1 } });

        // Initial rule

        // 2Na + Cl2 -> 2NaCl
        await repositoty.CreateNewRule(Helpers.BuildRuleItems(
        new Dictionary<long, int>
        {
            { Na_ID, 2 },
            { Cl2_ID, 1 }
        },
        new Dictionary<long, int>
        {
            { NaCl_ID, 2 }
        }
        ));

        // Cl2 + H2O -> HCl + HClO
        await repositoty.CreateNewRule(Helpers.BuildRuleItems(
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
        ));

        // 2NaCl + 2H2O -> Cl2 + H2 + 2NaOH
        await repositoty.CreateNewRule(Helpers.BuildRuleItems(
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
        ));

        // S + O2 -> SO2
        await repositoty.CreateNewRule(Helpers.BuildRuleItems(
        new Dictionary<long, int>
        {
            { S_ID, 1 },
            { O2_ID, 1 },
        },
        new Dictionary<long, int>
        {
            { SO2_ID, 1 },
        }
        ));

        // 2SO2 + O2 -> 2SO3
        await repositoty.CreateNewRule(Helpers.BuildRuleItems(
        new Dictionary<long, int>
        {
            { SO2_ID, 2 },
            { O2_ID, 1 },
        },
        new Dictionary<long, int>
        {
            { SO3_ID, 2 },
        }
        ));

        // SO3 + H2O -> H2SO4
        await repositoty.CreateNewRule(Helpers.BuildRuleItems(
        new Dictionary<long, int>
        {
            { SO3_ID, 1 },
            { H2O_ID, 1 },
        },
        new Dictionary<long, int>
        {
            { H2SO4_ID, 2 },
        }
        ));

        // 2NaCl + H2SO4 -> Na2SO4 + 2HCl
        await repositoty.CreateNewRule(Helpers.BuildRuleItems(
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
        ));

        // 4NaOH -> 4Na + 2H2O + O2
        await repositoty.CreateNewRule(Helpers.BuildRuleItems(
        new Dictionary<long, int>
        {
            { NaOH_ID, 4 },
        },
        new Dictionary<long, int>
        {
            { Na_ID, 4 },
            { H2O_ID, 2 },
            { O2_ID, 1 },
        }
        ));

        IsInitnowledge = true;
    }

    public async Task<IList<Chemical_Rule>> BackwardChaining(IList<long> initCompoundIds, IList<long> targetCompoundIds)
    {
        var repositoty = _factory.CreateChemicalRepository("jsonFile");
        var compounds = await repositoty.GetAvailableCompounds();
        var atoms = GetAtoms(initCompoundIds, compounds);

        var relatedRules = await repositoty.FindRuleFromAtoms(atoms);

       
        throw new NotImplementedException();
    }

    private IList<long> SearchRules(IList<long> initCompoundIds, IList<long> currentCompoundIds, IList<Chemical_Rule> rules)
    {
       
        if (currentCompoundIds.All(unknownId => initCompoundIds.Contains(unknownId)))
        {

        }
    }

    private IList<Atom> GetAtoms(IList<long> initCompoundIds, IList<Chemical_Compound> compounds)
    {
        var result = new List<Atom>();
        foreach (var compoundId in initCompoundIds)
        {
            var compound = compounds.FirstOrDefault(x => x.Id == compoundId);
            if (compound == null) continue;

            foreach (var formula in compound.FormulaDetails)
            {
                if (!result.Contains(formula.Atom))
                {
                    result.Add(formula.Atom);
                }
            }
            
        }
        return result;
    }
}