using Ennui.Api.Direct.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
    /// Represents a building within the scene.
    /// </summary>
    public interface IBuildingObject : IWorldObject
    {
        /// <summary>
        /// The internal xml config instance used by the game.
        /// 
        /// TODO Remove for muh abstraction
        /// </summary>
        object XmlConfig { get; }

        /// <summary>
        /// Retrieves this building's view.
        /// </summary>
        /// <value>This building's view.</value>
        IBuildingView BuildingView { get; }

        /// <summary>
        /// Attempts to open the interface for this building.
        /// </summary>
        bool Open();
    }
}
