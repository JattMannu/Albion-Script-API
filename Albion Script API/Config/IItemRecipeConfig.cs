namespace Ennui.Api.Config
{
    /// <summary>
    /// Contains configuration information about an item recipe.
    /// </summary>
    public interface IItemRecipeConfig
    {
        /// <summary>
        /// All resources required to make this recipe.
        /// </summary>
        IItemRecipeResourceConfig[] Resources { get; }
    }
}
