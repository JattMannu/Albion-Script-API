using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
    /// Represents a treasure chest within the scene.
    /// </summary>
    public interface ITreasureChestObject : IWorldObject
    {
        /// <summary>
        /// Retrieves this treasure chest's item container.
        /// </summary>
        /// <returns>This treasure chest's item container.</returns>
        IItemContainerProxy GetItemContainerProxy();
    }
}