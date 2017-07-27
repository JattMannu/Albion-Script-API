using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IStateQueue
    {
        /// <summary>
        /// TODO remove muh abstraction
        /// </summary>
        object CurrentState { get; }

        /// <summary>
        /// TODO remove muh abstraction
        /// </summary>
        Dictionary<int, object> States { get; }

        /// <summary>
        /// The state index. This can be used as a key.
        /// </summary>
        int StateIndex { get; }
    }
}
