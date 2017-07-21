using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
    /// Represents a timestamp that uses nanoseconds.
    /// </summary>
    public interface INanoTime
    {
        /// <summary>
        /// The time stored in a long as nanosecond format.
        /// </summary>
        long TimeInNanoSeconds { get; }
    }
}
