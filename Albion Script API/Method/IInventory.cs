using Ennui.Api.Direct;
using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utility methods for interacting with the local player's inventory.
	/// </summary>
    public interface IInventory : IApiModule
    {
        /// <summary>
        /// Checks if the local player's inventory has any items with integrity under
        /// the provided amount.
        /// </summary>
        /// <returns><c>true</c>, if the local player's inventory has items with integrity under the provided amount, <c>false</c> otherwise.</returns>
        /// <param name="amount">Amount.</param>
        bool HasBrokenItems(int amount);

        /// <summary>
        /// Gets the container holding all inventory items.
        /// </summary>
        /// <value>The container holding all of the local player's inventory items.</value>
        IItemContainerProxy Container { get; }

        /// <summary>
        /// Retrieves a list of all items from the inventory.
        /// </summary>
        /// <value>All items within the inventory.</value>
        List<IItemStack> AllItems { get; }

        /// <summary>
        /// Retrieves a list of all item stacks that have any of the provided names.
        /// </summary>
        /// <returns>A list of item containing all items in the inventory with one of the provided unique names.</returns>
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
        /// on equipment help by the local player.
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
