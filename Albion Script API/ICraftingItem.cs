using Ennui.Api.Xml;

namespace Ennui.Api
{
    /// <summary>
    /// A description of an item that can be crafted.
    /// </summary>
    public interface ICraftingItem
    {
        /// <summary>
        /// The configuration information of the crafted item.
        /// </summary>
        IItemConfig ItemConfig { get; }

        /// <summary>
        /// The unique name of the crafted item.
        /// </summary>
        string UniqueName { get; }

        /// <summary>
        /// The number of items crafted.
        /// </summary>
        int StackSize { get; }
    }
}
