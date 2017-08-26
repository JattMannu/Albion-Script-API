using System.Collections.Generic;

using Ennui.Api.Meta;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utility methods for interacting with the local player's equipment container.
	/// </summary>
    public interface IEquipment : IApiModule
    {
        /// <summary>
        /// Checks if the local player's equipment has any items with integrity under
        /// the provided amount.
        /// </summary>
        /// <returns><c>true</c>, if the local player's equipment has items with integrity under the provided amount, <c>false</c> otherwise.</returns>
        /// <param name="amount">Amount.</param>
        bool HasBrokenItems(int amount);

        /// <summary>
        /// Gets the container holding all equipment items.
        /// </summary>
        /// <value>The container holding all of the local player's equipment items.</value>
        IItemContainerProxy Container { get; }

        /// <summary>
        /// Retrieves a list of all items from the equipment container.
        /// </summary>
        /// <value>All items within the equipment container.</value>
        List<IItemStack> AllItems { get; }

        /// <summary>
        /// Retrieves a list of all item stacks that have any of the provided names.
        /// </summary>
        /// <returns>A list of item containing all items in the equipment container with one of the provided unique names.</returns>
        /// <param name="uniqueNames">The unique names that an item must have to be considered.</param>
        List<IItemStack> GetItemsByName(params string[] uniqueNames);

        /// <summary>
        /// Retrieves all items that have a unique name containing any of the provided
        /// substrings.
        /// </summary>
        /// <returns>The items which have unique names containing any of the provided substrings.</returns>
        /// <param name="substrings">Substrings.</param>
        List<IItemStack> GetItemsBySubstring(params string[] substrings);

        /// <summary>
        /// The names to check.
        /// </summary>
        /// <returns>The tier of the highest tier item name.</returns>
        /// <param name="names">Names.</param>
        int HighestTierByName(params string[] names);

        /// <summary>
        /// Calculates the maximum tier of resources that we can harvest, based
        /// on equipment held by the local player.
        /// </summary>
        /// <returns>The maximum tier we of the resource we can currently harvest.</returns>
        /// <param name="type">Type.</param>
        int MaxTierForEquipment(ResourceType type);

        /// <summary>
        /// Checks if the inventory has any item with one of the provided names in their name.
        /// </summary>
        /// <param name="names">The names to match items against</param>
        /// <returns>If the inventory has any items with one of the provided names in them</returns>
        bool HasItemContainingName(params string[] names);
    }
}
