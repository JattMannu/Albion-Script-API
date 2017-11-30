using Ennui.Api.Xml;

namespace Ennui.Api.Object
{
    /// <summary>
    /// Represents a building within the scene.
    /// </summary>
    public interface IBuildingObject : IWorldObject
    {
        /// <summary>
        /// This farmable object's xml config.
        /// </summary>
        IBuildingConfig BuildingConfig { get; }

        /// <summary>
        /// Attempts to open the interface for this building.
        /// </summary>
        bool Open();
    }
}
