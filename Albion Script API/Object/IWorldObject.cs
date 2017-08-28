using Ennui.Api.View;

namespace Ennui.Api.Object
{
    /// <summary>
	/// Represents an object within the game scene.
	/// </summary>
	public interface IWorldObject : ISimulationObject
    {
        /// <summary>
        /// This world object's view
        /// 
        /// TODO Remove for abstractions
        /// </summary>
        IWorldObjectView WorldView { get; }

        /// <summary>
        /// Clicks on this object.
        /// </summary>
        bool Click();
    }
}
