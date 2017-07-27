using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
    /// Represents something that can be placed in the world.
    /// 
    /// TODO remove for muh abstraction
    /// </summary>
    public interface IPlaceableObject
    {
        /// <summary>
        /// The internal placement config used by the game.
        /// </summary>
        object PlacementConfig { get; }
    }
}
