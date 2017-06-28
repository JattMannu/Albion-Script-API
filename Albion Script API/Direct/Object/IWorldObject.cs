using Ennui.Api.Direct.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
	/// Represents a world object within the game scene.
	/// </summary>
	public interface IWorldObject : ISimulationObject
    {
        IWorldObjectView WorldView { get; }

        /// <summary>
        /// Clicks on this world object using the local player's character view.
        /// </summary>
        bool Click();
    }
}
