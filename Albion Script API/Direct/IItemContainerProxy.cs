using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IItemContainerProxy
    {
        IItemContainer ItemContainer { get; }
        float MaximumHoldWeight { get; }
        float CurrentHoldWeight { get; }
        List<IItemStack> ValidItems { get; }
        int FirstFreeSlot { get; }
        int Capacity { get; }
        int UsedSlots { get; }
        int FreeSlots { get; }
        bool IsFull { get; }
        bool IsEmpty { get; }
        Guid TrackerGuid { get; }

        List<IItemStack> GetItemsByName(params string[] uniqueNames);
        List<IItemStack> GetItemsBySubstring(params string[] substrings);

        bool CanHoldWeight(float weight);
    }
}
