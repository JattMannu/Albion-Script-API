namespace Ennui.Api
{
    /// <summary>
	/// Represents information about a resource within the scene.
	/// </summary>
    public interface IHarvestable
    {
        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        /// <value>The type of the resource.</value>
        string Type { get; }

        /// <summary>
        /// Gets the tier of the resource.
        /// </summary>
        /// <value>The tier of the resource.</value>
        int Tier { get; }

        /// <summary>
        /// Gets the remaining charges on the resource.
        /// </summary>
        /// <value>The remaining charges on the resource.</value>
        int Charges { get; }

        /// <summary>
        /// Gets the rarity of the resource.
        /// </summary>
        /// <value>The rarity of the resource.</value>
        int Rarity { get; }
    }
}
