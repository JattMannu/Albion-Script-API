using Ennui.Api.Builder;
using Ennui.Api.Direct.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
		/// A map containing a lookup from object id -> object instances.
		/// </summary>
		/// <value>The object map.</value>
		 IDictionary ObjectMap { get; }

        /// <summary>
        /// A map containing a lookup from object id -> object instances.
        /// </summary>
        /// <value>The object map.</value>
        Dictionary<long, object> ConvObjectMap { get; }

        /// <summary>
        /// Checks if the scene contains an object with the provided id.
        /// </summary>
        /// <returns><c>true</c>, if object was containsed, <c>false</c> otherwise.</returns>
        /// <param name="id">Identifier.</param>
        bool ContainsObject(long id);

        /// <summary>
        /// The number of objects currently loaded in the scene.
        /// </summary>
        /// <value>The object count.</value>
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
        /// Gets all harvestables.
        /// </summary>
        /// <value>A list of every harvestable within the currently loaded map region.</value>
         List<IHarvestableObject> AllHarvestables { get; }

        /// <summary>
        /// Retrieves all harvestables, and adds them to a filter chain.
        /// </summary>
        /// <value>A filter chain containing all harvestables within the currently loaded map region.</value>
       HarvestableFilterChain HarvestableChain { get; }

        /// <summary>
        /// Gets all buildings.
        /// </summary>
        /// <value>A list of every building within the currently loaded map region.</value>
        List<IBuildingObject> AllBuildings { get; }

        /// <summary>
        /// Gets all bank buildings.
        /// </summary>
        /// <value>A list of every bank building within the currently loaded map region.</value>
       List<IBankBuildingObject> BankBuildings { get; }

        /// <summary>
        /// Retrieves all bank buildings, and adds them to a filter chain.
        /// </summary>
        /// <value>A filter chain containing all bank buildings within the currently loaded map region.</value>
        BankBuildingFilterChain BankChain { get; }

        /// <summary>
        /// Gets all repair buildings.
        /// </summary>
        /// <value>A list of every repair building within the currently loaded map region.</value>
         List<IRepairBuildingObject> RepairBuildings { get; }

        /// <summary>
        /// Retrieves all repair buildings, and adds them to a filter chain.
        /// </summary>
        /// <value>A filter chain containing all repair buildings within the currently loaded map region.</value>
        RepairBuildingFilterChain RepairChain { get; }

        /// <summary>
        /// Gets all farmables.
        /// </summary>
        /// <value>A list of every farmable within the currently loaded map region.</value>
        List<IFarmableObject> Farmables { get; }

        /// <summary>
        /// Gets all travel points.
        /// </summary>
        /// <value>A list of every travel point within the currently loaded map region.</value>
        List<ITravelPointObject> TravelPoints { get; }

        /// <summary>
        /// Retrieves all travel points, and adds them to a filter chain.
        /// </summary>
        /// <value>A filter chain containing all travel points within the currently loaded map region.</value>
        TravelPointFilterChain TravelPointChain { get; }

        /// <summary>
        /// Gets all silver objects.
        /// </summary>
        /// <value>A list of every silver object within the currently loaded map region.</value>
        List<ISilverObject> AllSilver { get; }
    }
}
