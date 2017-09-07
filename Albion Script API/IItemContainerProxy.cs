using System;
using System.Collections.Generic;

namespace Ennui.Api
{
    /// <summary>
    /// Acts as a wrapper for an item container.
    /// </summary>
    public interface IItemContainerProxy
    {
        /// <summary>
        /// The maximum amount of weight that this container can hold.
        /// </summary>
        float MaximumHoldWeight { get; }

        /// <summary>
        /// The current amount of weight stored in this container.
        /// </summary>
        float CurrentHoldWeight { get; }

        /// <summary>
        /// A list of item stacks within this container.
        /// </summary>
        List<IItemStack> ValidItems { get; }

        /// <summary>
        /// The first slot in this container that has no item stack.
        /// </summary>
        int FirstFreeSlot { get; }

        /// <summary>
        /// The maximum amount of items that can be stored in this container.
        /// </summary>
        int Capacity { get; }
        
        /// <summary>
        /// The amount of slots with item stacks within them.
        /// </summary>
        int UsedSlots { get; }

        /// <summary>
        /// The amount of slots without item stacks within them.
        /// </summary>
        int FreeSlots { get; }

        /// <summary>
        /// If this item container has no free slots.
        /// </summary>
        bool IsFull { get; }

        /// <summary>
        /// If this item container has no item stacks.
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// This item container's tracker guid.
        /// </summary>
        Guid TrackerGuid { get; }

        /// <summary>
        /// Finds all items with the specified unique names.
        /// </summary>
        /// <param name="uniqueNames">The names of the items to search for.</param>
        /// <returns>All items with one of the provided unique names.</returns>
        List<IItemStack> GetItemsByName(params string[] uniqueNames);

        /// <summary>
        /// Finds all items that contain a substring in their unique name.
        /// </summary>
        /// <param name="substrings">The substrings to search for in item names.</param>
        /// <returns>Any item containing one of the provided sub strings in its unique name.</returns>
        List<IItemStack> GetItemsBySubstring(params string[] substrings);

        /// <summary>
        /// Calculates if this container can have the provided amount of weight
        /// added to it.
        /// </summary>
        /// <param name="weight">The amount of weight.</param>
        /// <returns>If the weight can be added.</returns>
        bool CanHoldWeight(float weight);

        /// <summary>
        /// This container's guid.
        /// </summary>
        Guid Guid { get; }
    }
}
