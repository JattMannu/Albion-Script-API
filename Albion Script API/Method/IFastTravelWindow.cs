using Ennui.Api.Direct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    public interface IFastTravelWindow : IApiModule
    {
        bool IsOpen { get; }

        List<IFastTravelData> PossibleDestinations { get; }

        bool TravelTo(string islandName);
    }
}
