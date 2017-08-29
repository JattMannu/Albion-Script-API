using System.Collections;
using System.Collections.Generic;

using Ennui.Api.Object;
using Ennui.Api.Filter;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Handles the conversion from one type to another.
	/// </summary>
	/// <returns>The old object in a new type</returns>
	public delegate N Converter<I, N>(I i);

    /// <summary>
    /// Provides a set of static utility methods for game objects.
    /// </summary>
    public interface IObjects : IApiModule
    {
        /// <summary>
        /// A map containing all objects, using the object ids as keys
        /// </summary>
        IDictionary ObjectMap { get; }

        /// <summary>
        /// A map containing all wrapped objects, using the object ids as keys
        /// </summary>
        Dictionary<long, object> ConvObjectMap { get; }

        /// <summary>
        /// Checks if the scene contains an object with the provided id.
        /// </summary>
        /// <returns><c>true</c>, if object was containsed, <c>false</c> otherwise.</returns>
        /// <param name="id">Identifier.</param>
        bool ContainsObject(long id);

        /// <summary>
        /// The total amount of objects within the scene.
        /// </summary>
        int ObjectCount { get; }

        /// <summary>
        /// Retrieves all objects in the scene of the provided type.
        /// </summary>
        /// <returns>The list of found objects of the provided type.</returns>
        /// <param name="type">The type of object to search for.</param>
        /// <param name="converter">The delegate that will handle conversion from raw objects.</param>
        /// <typeparam name="N">The type of object that we're converting to.</typeparam>
        List<N> ObjectsOfType<N>(string type, Converter<object, N> converter) where N : ISimulationObject;

        /// <summary>
        /// Retrieves the SimulationObject with the provided unique id.
        /// </summary>
        /// <returns>The SimulationObject with the provided unique id.</returns>
        /// <param name="id">The unique id of the SimulationObject to retrieve.</param>
        ISimulationObject ForId(long id);

        /// <summary>
        /// All harvestables within the scene.
        /// </summary>
        List<IHarvestableObject> AllHarvestables { get; }

        /// <summary>
        /// A chain containing all harvestables within the scene.
        /// </summary>
        HarvestableFilterChain HarvestableChain { get; }

        /// <summary>
        /// All buildings within the scene.
        /// </summary>
        List<IBuildingObject> AllBuildings { get; }

        /// <summary>
        /// All bank buildings within the scene.
        /// </summary>
        List<IBankBuildingObject> BankBuildings { get; }

        /// <summary>
        /// A chain containing all bank buildings within the scene.
        /// </summary>
        BankBuildingFilterChain BankChain { get; }

        /// <summary>
        /// All repair buildings within the scene.
        /// </summary>
        List<IRepairBuildingObject> RepairBuildings { get; }

        /// <summary>
        /// A chain containing all repair buildings within the scene.
        /// </summary>
        RepairBuildingFilterChain RepairChain { get; }

        /// <summary>
        /// All farmables within the scene.
        /// </summary>
        List<IFarmableObject> Farmables { get; }

        /// <summary>
        /// A chain containing all farmables within the scene.
        /// </summary>
        FarmableFilterChain FarmableChain { get; }

        /// <summary>
        /// All travel points within the scene.
        /// </summary>
        List<ITravelPointObject> TravelPoints { get; }

        /// <summary>
        /// A chain containing all travel points within the scene.
        /// </summary>
        TravelPointFilterChain TravelPointChain { get; }

        /// <summary>
        /// All silver within the scene.
        /// </summary>
        List<ISilverObject> AllSilver { get; }

        /// <summary>
        /// A chain containing all silver within the scene.
        /// </summary>
        SilverFilterChain SilverChain { get; }

        /// <summary>
        /// All hellgates within the scene.
        /// </summary>
        List<IHellgateObject> Hellgates { get; }

        /// <summary>
        /// A chain containing all hellgates within the scene.
        /// </summary>
        HellgateFilterChain HellgateChain { get; }

        /// <summary>
        /// All teleport stones within the scene.
        /// </summary>
        List<ITeleportStoneObject> TeleportStones { get; }

        /// <summary>
        /// A chain containing all teleport stones within the scene.
        /// </summary>
        TeleportStoneFilterChain TeleportStoneChain { get; }

        /// <summary>
        /// All spell effect areas within the scene.
        /// </summary>
        List<ISpellEffectAreaObject> SpellEffectAreas { get; }

        /// <summary>
        /// A chain containing all spell effect areas within the scene.
        /// </summary>
        SpellEffectAreaFilterChain SpellEffectAreaChain { get; }

        /// <summary>
        /// All exits within the scene.
        /// </summary>
        List<IExitObject> Exits { get; }

        /// <summary>
        /// A chain containing all exits within the scene.
        /// </summary>
        ExitFilterChain ExitChain { get; }

        /// <summary>
        /// All expedition agents within the scene.
        /// </summary>
        List<IExpeditionAgentObject> ExpeditionAgents { get; }

        /// <summary>
        /// A chain containing all expedition agents within the scene.
        /// </summary>
        ExpeditionAgentFilterChain ExpeditionAgentChain { get; }
    }
}
