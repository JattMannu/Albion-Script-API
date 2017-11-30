namespace Ennui.Api.Config
{
    /// <summary>
    /// Contains configuration information about an item recipe resource (i.e. a single item in a crafting recipe.)
    /// </summary>
    public interface IItemRecipeResourceConfig
    {
        /// <summary>
        /// The unique name of the resource.
        /// </summary>
        string UniqueName { get; }
    }
}
