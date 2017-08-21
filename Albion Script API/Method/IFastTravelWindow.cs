using System.Collections.Generic;

using Ennui.Api.Direct;
using Ennui.Api.Direct.Xml;

namespace Ennui.Api.Method
{
    public interface IFastTravelWindow : IApiModule
    {
        bool IsOpen { get; }

        List<IFastTravelData> PossibleDestinations { get; }

        List<IXmlTravelDestination> PossibleDestinationsXml { get; }

        bool TravelTo(string islandName);
    }
}
