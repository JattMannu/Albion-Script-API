﻿using System.Collections.Generic;

using Ennui.Api.Xml;

namespace Ennui.Api.Method
{
    public interface IFastTravelWindow : IApiModule, IWidget
    {
        bool IsOpen { get; }

        List<IFastTravelData> PossibleDestinations { get; }

        List<IXmlTravelDestination> PossibleDestinationsXml { get; }

        bool TravelTo(string islandName);
    }
}
