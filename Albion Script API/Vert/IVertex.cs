using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Vert
{
    /// <summary>
	/// Represents a single position within a Graph.
	/// </summary>
	public interface IVertex
    {
        /// <summary>
        /// The unique id of thie vertex.
        /// </summary>
        int UniqueId { get; set; }

        /// <summary>
        /// The 3d coordinates of this Vertex.
        /// </summary>
        Vector3<float> Point { get; set; }

        /// <summary>
        /// The name of this Vertex. Only used for debugging.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// A list of Vertices that this Vertex inks to.
        /// </summary>
        List<IVertex> Linked { get; set; }

        /// <summary>
        /// A list of attributes belonging to this Vertex.
        /// </summary>
        List<string> Attributes { get; set; }

        /// <summary>
        /// A 3d box area surrounding this Vertex.
        /// </summary>
        /// <value>A 3d box area surrounding this Vertex.</value>
        IArea<float> PointArea { get; }

        /// <summary>
        /// Links together 2 vertices to form a path.
        /// </summary>
        /// <param name="v">The vertex to link together.</param>
        void Link(IVertex v);

        /// <summary>
        /// Unlinks 2 linked vertices that are currently forming a path.
        /// </summary>
        /// <param name="v">The vertex to unlink.</param>
        void Unlink(IVertex v);

        /// <summary>
        /// Unlinks this vertex from all other linked vertices.
        /// </summary>
        void Unlink();
    }
}
