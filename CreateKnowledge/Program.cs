using Knowledge.Business.Chemical;
using Knowledge.Core.Chemical;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CreateKnowledge;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start create knowledge...");

        var factory = new ChemicalRepositoryFactory();

        var task = InitKnowledge(factory);
        task.Wait();

        Console.WriteLine("Create knowledge successfully =))");
        Console.ReadLine();
    }


    public async static Task InitKnowledge(ChemicalRepositoryFactory factory)
    {
        var repositoty = factory.CreateChemicalRepository("jsonFile");

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
        var NaCl_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.Na, 1 }, { Atom.Cl, 1 } });
        var Na2SO4_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.Na, 2 }, { Atom.S, 1 }, { Atom.O, 4 } });
        var HCl_ID = await repositoty.CreateNewCompound(new Dictionary<Atom, int> { { Atom.H, 1 }, { Atom.Cl, 1 } });
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
    }

}
