using System.Collections.Generic;

using Ennui.Api.Vert;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Acts as a directory for Graphs in each cluster.
	/// </summary>
	public interface IGraphs
    {
        /// <summary>
        /// A map of display name -> Graphs
        /// </summary>
        Dictionary<string, IGraph> DisplayNameMap { get; }

        /// <summary>
        /// A map of unique name -> Graphs
        /// </summary>
        Dictionary<string, IGraph> UniqueNameMap { get; }

        /// <summary>
        /// Retrieves a list of all Graphs registered to the directory.
        /// </summary>
        /// <value>All Graphs registered to the directory.</value>
        List<IGraph> Areas { get; }

        /// <summary>
        /// Attempts to find a Graph that has the provided unique name.
        /// 
        /// If a Graph isn't found, a default one is created.
        /// </summary>
        /// <param name="uniqueName">The Graph with the provided unique name.</param>
        IGraph LookupByUniqueName(string uniqueName);

        /// <summary>
        /// Attempts to find a Graph that has the provided cluster name.
        /// 
        /// If a Graph isn't found, a default one is created.
        /// </summary>
        /// <param name="displayName">The Graph with the provided name.</param>
        IGraph LookupByDisplayName(string displayName);

        /// <summary>
        /// Removes all Graphs from the directory.
        /// </summary>
        void Clear();

        /// <summary>
        /// Stores a Graph in the global directories, overwriting any
        /// existing ones.
        /// </summary>
        /// <param name="graph">The Graph to add.</param>
        void Overwrite(IGraph graph);

        /// <summary>
        /// Adds a Graph to the directory.
        /// </summary>
        /// <param name="graph">The Graph to add to the directory.</param>
        void Add(IGraph graph);
    }
}
