namespace Ennui.Api.Object
{
    /// <summary>
    /// Represents a building within the scene.
    /// </summary>
    public interface IBuildingObject : IWorldObject
    {
        /// <summary>
        /// Attempts to open the interface for this building.
        /// </summary>
        bool Open();
    }
}
