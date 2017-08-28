namespace Ennui.Api
{
    /// <summary>
    /// Represents a cluster that has been populated with scene information.
    /// </summary>
    public interface IBoundCluster
    {
        /// <summary>
        /// The static context of this cluster.
        /// </summary>
        IMapCluster Unbound { get; }
    }
}
