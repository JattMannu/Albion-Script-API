using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IFastTravelData : IApiResource
    {
        string IslandName { get; }
    }
}
