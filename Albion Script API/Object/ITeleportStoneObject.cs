namespace Ennui.Api.Object
{
    /// <summary>
    /// Represents a teleport stone within the scene.
    /// </summary>
    public interface ITeleportStoneObject : IWorldObject
    {
        /// <summary>
        /// The internal cluster name of the destination.
        /// </summary>
        string DestinationCluster { get; }
    }
}