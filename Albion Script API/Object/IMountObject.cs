using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Object
{
    public interface IMountObject : ISimulationObject
    {
        bool IsOurs { get; }
    }
}
