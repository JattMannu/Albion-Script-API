namespace Ennui.Api.Object
{
    /// <summary>
    /// Represents a pile of silver within the scene.
    /// </summary>
    public interface ISilverObject : IWorldObject
    {
        /// <summary>
        /// If this silver is protected (i.e. we can't take it)
        /// </summary>
        bool Protected { get; }
    }
}
