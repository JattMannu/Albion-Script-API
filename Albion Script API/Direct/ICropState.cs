using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface ICropState
    {
        INanoTime TimeRemaining { get; }

        INanoTime TotalDuration { get; }
    }
}
