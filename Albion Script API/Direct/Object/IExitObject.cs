namespace Ennui.Api.Direct.Object
{
    /// <summary>
    /// Represents a link between two map clusters.
    /// </summary>
    public interface IExitObject : IWorldObject
    {
        /// <summary>
        /// The cluster that this exit object links to.
        /// </summary>
        IBoundCluster BoundCluster { get; }
    }
}
