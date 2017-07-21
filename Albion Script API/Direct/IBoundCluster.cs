using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
    /// Represents a cluster that has been populated with scene information.
    /// </summary>
    public interface IBoundCluster
    {
        IMapCluster Unbound { get; }
    }
}
