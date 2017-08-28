using System.Collections.Generic;

using Ennui.Api.Meta;
using Ennui.Api.Util;

namespace Ennui.Api.Vert
{
    /// <summary>
	/// Represents a graph that the bot can use for path finding. This is your typical graph,
	/// with vertices, and edges. The only difference is that we also store map information.
	/// 
	/// Please note that every vertex must be directly, or indirectly all linked together.
	/// If this doesn't happen, you can not effectively path find using the graph.
	/// </summary>
	public interface IGraph
    {
        /// <summary>
        /// The unique name of the cluster that this graph belongs to.
        /// </summary>
        string UniqueName { get; set; }

        /// <summary>
        /// The display name of the cluster that this graph belongs to.
        /// </summary>
        string DisplayName { get; set; }

        /// <summary>
        /// All of the vertices scattered around the map.
        /// </summary>
        List<IVertex> Vertices { get; set; }

        /// <summary>
        /// A list of edges to other graphs.
        /// </summary>
        List<IGraphEdge> WebEdges { get; set; }

        /// <summary>
        /// A list of terrirories within the map.
        /// </summary>
        List<ITerritory> Territories { get; set; }

        /// <summary>
        /// The offset of the cluster within the 3d scene.
        /// </summary>
        Vector2<float> Origin { get; set; }

        /// <summary>
        /// The type of cluster that this graph belongs to.
        /// </summary>
        ClusterType Type { get; set; }

        /// <summary>
        /// If this graph.. has a graph? Wat FIXME TODO
        /// </summary>
        bool HasWeb { get; set; }

        /// <summary>
        /// Calculates the closest vertex to the provided position.
        /// </summary>
        /// <param name="vec">The closest vertex to the provided position.</param>
        IVertex Closest(Vector3<float> vec);

        /// <summary>
        /// Attempts to find a vertex with the provided unique id.
        /// </summary>
        /// <returns>The vertex with the provided unique id, or null if no such vertex exists.</returns>
        /// <param name="uid">The unique id of the vertex that we want to grab.</param>
        IVertex VertByUniqueId(int uid);

        /// <summary>
        /// Attempts to find a vertex with the provided 3d scene coordinates.
        /// </summary>
        /// <returns>The vertex with the provided 3d scene coordinates, or null if no such vertex exists.</returns>
        /// <param name="loc">The location of the vertex that we want to grab.</param>
        IVertex VertByPoint(Vector3<float> loc);

        /// <summary>
        /// Returns a random vertex from this graph.
        /// </summary>
        IVertex Random();

        /// <summary>
        /// Adds a list of vertices to this graph.
        /// </summary>
        /// <param name="vs">Vs.</param>
        void AddVertex(params IVertex[] vs);

        /// <summary>
        /// Removes a list of vertices from this graph.
        /// </summary>
        /// <param name="vs">Vs.</param>
        void RemoveVertex(params IVertex[] vs);

        /// <summary>
        /// Adds a list of edges to this graph.
        /// 
        /// These edges are used for traversal across multiple graphs.
        /// </summary>
        /// <param name="ls">Ls.</param>
        void AddGraphEdge(params IGraphEdge[] ls);
    }
}
