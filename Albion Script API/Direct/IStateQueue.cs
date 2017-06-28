using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IStateQueue
    {
        object CurrentState { get; }

        Dictionary<int, object> States { get; }

        int StateIndex { get; }
    }
}
