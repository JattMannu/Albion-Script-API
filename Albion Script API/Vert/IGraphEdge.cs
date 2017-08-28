using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Vert
{
    /// <summary>
	/// Represents a link between 2 Graphs.
	/// </summary>
	public interface IGraphEdge
    {
        /// <summary>
        /// The x coordinate of where the transition begins to the next graph.
        /// </summary>
        /// <value>The x coordinate of where the transition begins to the next graph.</value>
        float X { get; set; }

        /// <summary>
        /// The y coordinate of where the transition begins to the next graph.
        /// </summary>
        /// <value>The y coordinate of where the transition begins to the next graph.</value>
        float Y { get; set; }

        /// <summary>
        /// The z coordinate of where the transition begins to the next graph.
        /// </summary>
        /// <value>The z coordinate of where the transition begins to the next graph.</value>
        float Z { get; set; }

        /// <summary>
        /// The Graph that this edge links to.
        /// </summary>
        /// <value>The Graph that this edge links to.</value>
        IGraph To { get; set; }
    }
}
