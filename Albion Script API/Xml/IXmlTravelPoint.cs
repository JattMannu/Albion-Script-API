using System.Collections.Generic;

namespace Ennui.Api.Xml
{
    public interface IXmlTravelPoint
    {
        List<IXmlTravelDestination> Destinations { get; }
    }
}
