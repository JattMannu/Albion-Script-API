namespace Ennui.Api.Vert
{
    /// <summary>
    /// Represents a complex edge in a graph *i.e. travel points.)
    /// </summary>
    public interface ITravelGraphEdge : IGraphEdge
    {
        /// <summary>
        /// The amount of silver required to take the edge.
        /// </summary>
        int SilverCost { get; }
    }
}
