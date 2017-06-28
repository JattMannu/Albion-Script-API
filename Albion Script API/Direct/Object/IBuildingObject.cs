using Ennui.Api.Direct.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    public interface IBuildingObject : IWorldObject
    {
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
