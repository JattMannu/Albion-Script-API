using Ennui.Api.Xml;

namespace Ennui.Api
{
    public interface ICraftingItem
    {
        IItemConfig ItemConfig { get; }

        string UniqueName { get; }

        int StackSize { get; }
    }
}
