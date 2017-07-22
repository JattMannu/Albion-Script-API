using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Meta
{
    /// <summary>
    /// Whenever the local player tries to harvest a resource, it does a handful of checks, and returns
    /// a numerical value depending on the state. 0 is success, everything else is a failure of some sort (e.g. someone else killed the mob.)
    /// </summary>
    public enum HarvestableSetupState
    {
        Invalid = 100,
    }
}
