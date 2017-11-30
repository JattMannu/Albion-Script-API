using System.Collections.Generic;

namespace Ennui.Api.Xml
{
    /// <summary>
    /// Contains configuration information about a travel point.
    /// </summary>
    public interface ITravelPointConfig
    {
        /// <summary>
        /// A list of configurations for all possible destinations from this point.
        /// </summary>
        List<ITravelDestinationConfig> Destinations { get; }
    }
}
