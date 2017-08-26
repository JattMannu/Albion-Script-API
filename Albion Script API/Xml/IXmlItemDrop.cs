using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Xml
{
    /// <summary>
	/// Contains configuration information about a drop from a mob
	/// that drops a resource node.
	/// </summary>
	public interface IXmlItemDrop : IXmlDrop
    {
        /// <summary>
        /// Retrieves the type of resource node that is dropped.
        /// </summary>
        /// <value>The type of item that is dropped.</value>
        string Type { get; }
    }
}
