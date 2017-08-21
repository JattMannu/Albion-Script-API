using System.Collections.Generic;

namespace Ennui.Api.Direct.Xml
{
    public interface IXmlTravelPoint
    {
        List<IXmlTravelDestination> Destinations { get; }
    }
}
