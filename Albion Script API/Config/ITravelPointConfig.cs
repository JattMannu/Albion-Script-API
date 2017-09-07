using System.Collections.Generic;

namespace Ennui.Api.Xml
{
    public interface ITravelPointConfig
    {
        List<ITravelDestinationConfig> Destinations { get; }
    }
}
