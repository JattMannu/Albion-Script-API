using System;

namespace Ennui.Api
{
    public interface IItemContainerTracker
    {
        /// <summary>
		/// Gets the guid of the provided ItemContainer.
		/// </summary>
		/// <returns>The GUID of the provided ItemContainer.</returns>
		/// <param name="container">Container.</param>
		Guid GetGuidOf(IItemContainerProxy container);

        /// <summary>
        /// Switches an item from one container to another.
        /// </summary>
        /// <param name="fromSlot">The slot to move the item from.</param>
        /// <param name="fromGuid">The guid of the container we are moving from.</param>
        /// <param name="toSlot">To slot to move the item to.</param>
        /// <param name="toGuid">To guid of the container we are moving to.</param>
        void SwitchItems(int fromSlot, Guid fromGuid, int toSlot, Guid toGuid);

        /// <summary>
        /// Drops an item (destroys it.)
        /// </summary>
        /// <param name="uid">The unique id of the item to drop.</param>
        void DropItem(long uid);
    }
}
