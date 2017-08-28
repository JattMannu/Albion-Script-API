using Ennui.Api.Xml;

namespace Ennui.Api
{
    /// <summary>
    /// Represents a single item stack within an item container.
    /// </summary>
    public interface IItemStack
    {
        /// <summary>
        /// The config for this item.
        /// </summary>
        IXmlItemConfig ItemXmlConfig { get; }

        /// <summary>
        /// The amount of items in this stack.
        /// </summary>
        int Amount { get; }

        /// <summary>
        /// The unique id of this item stack.
        /// </summary>
        long UniqueId { get; }

        /// <summary>
        /// This unique id of this item stack.
        /// </summary>
        string UniqueName { get; }

        /// <summary>
        /// The integrity of this item stack. Always 100 unless equipment.
        /// </summary>
        int Integrity { get; }

        /// <summary>
        /// The weight of this item stack.
        /// </summary>
        float Weight { get; }

        /// <summary>
        /// The slot that this item stack is in within its parent item container.
        /// </summary>
        int Slot { get; }

        /// <summary>
        /// Moves this item stack to another item container.
        /// </summary>
        /// <param name="proxy">The container to move the item to</param>
        /// <param name="toSlot">The slot to move it to</param>
        /// <returns>If the item was moved successfully.</returns>
        bool MoveTo(IItemContainerProxy proxy, int toSlot);

        /// <summary>
        /// Moves this item stack to another item container.
        /// </summary>
        /// <param name="proxy">The container to move the item to</param>
        /// <returns>If the item was moved successfully.</returns>
        bool MoveTo(IItemContainerProxy proxy);

        /// <summary>
        /// Attempts to drop this item. Clicks yes on warning. Use at own risk.
        /// </summary>
        /// <returns>If the item was dropped successfully.</returns>
        bool Drop();

        /// <summary>
        /// The placement ghost for this item.
        /// </summary>
        IPlaceableObject AsPlaceableObject { get; }

        /// <summary>
        /// If this item is a placement ghost.
        /// </summary>
        bool IsPlaceableObject { get; }

        /// <summary>
        /// Selects this item for placement within the world.
        /// </summary>
        void SelectForPlacement();
    }
}
