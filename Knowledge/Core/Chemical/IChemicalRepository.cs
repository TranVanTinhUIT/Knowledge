using Knowledge.Entities.Chemicals;

namespace Knowledge.Core.Chemical;

public interface IChemicalRepository
{
    /// <summary>
    /// Create new chemical compound
    /// </summary>
    /// <param name="name">friendly name of chemical</param>
    /// <param name="formularDetails">chemical formula of compound</param>
    /// <param name="properties">Properties of compounds such as: color, odor, etc.</param>
    /// <returns>Id of compound</returns>
    Task<long> CreateNewCompound(string? name, Dictionary<Atom, int> formularDetails, Dictionary<string, string>? properties = null);

    /// <summary>
    /// Create new chemical rule
    /// </summary>
    /// <param name="reactants">list compound on the left of rule with key: id of compound, value: number of mole weight</param>
    /// <param name="conclusions">list compound on the right of rule with key: id of compound, value: number of mole weight</param>
    /// <returns>id of rule</returns>
    Task<long> CreateNewRule(Dictionary<long, int> reactants, Dictionary<long, int> conclusions);

    /// <summary>
    /// Find a compound by id
    /// </summary>
    /// <param name="compoundId"></param>
    /// <returns>compound or null if it doesn't exist</returns>
    Task<Chemical_Compound?> FindCompound(long compoundId);

    /// <summary>
    /// Find all rule from atoms
    /// </summary>
    /// <param name="atoms">list atoms</param>
    /// <returns>List of related rules</returns>
    Task<IList<Chemical_Rule>> FindRuleFromAtoms(IList<Atom> atoms);

    /// <summary>
    /// Get all available compounds
    /// </summary>
    /// <returns></returns>
    Task<IList<Chemical_Compound>> GetAvailableCompounds();

    /// <summary>
    /// Get all available rules
    /// </summary>
    /// <returns></returns>
    Task<IList<Chemical_Rule>> GetAvailableRules();
}
