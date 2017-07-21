using Ennui.Api.Direct.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
	/// Represents an object within the game scene.
	/// </summary>
	public interface IWorldObject : ISimulationObject
    {
        IWorldObjectView WorldView { get; }

        /// <summary>
        /// Clicks on this object.
        /// </summary>
        bool Click();
    }
}
