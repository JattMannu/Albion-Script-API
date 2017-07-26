using Ennui.Api.Direct.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IItemStack
    {
        IXmlItemConfig ItemXmlConfig { get; }

        int Amount { get; }
        long UniqueId { get; }
        string UniqueName { get; }
        int Integrity { get; }
        float Weight { get; }
        int Slot { get; }

        bool MoveTo(IItemContainerProxy proxy, int toSlot);
        bool MoveTo(IItemContainerProxy proxy);
        bool Drop();

        IPlaceableObject AsPlaceableObject { get; }
        bool IsPlaceableObject { get; }
        void SelectForPlacement();
    }
}
