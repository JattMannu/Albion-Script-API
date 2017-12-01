namespace Ennui.Api.Object
{
    /// <summary>
	/// Represents an object within the game scene.
	/// </summary>
	public interface IWorldObject : ISimulationObject
    {
        /// <summary>
        /// Clicks on this object.
        /// </summary>
        bool Click();
    }
}
