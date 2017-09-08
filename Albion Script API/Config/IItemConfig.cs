using Ennui.Api.Config;

namespace Ennui.Api.Xml
{
    /// <summary>
	/// Contains configuration information about an item.
	/// </summary>
	public interface IItemConfig
    {
        /// <summary>
        /// This config's unique id.
        /// </summary>
        int UniqueId { get; }

        /// <summary>
        /// The unique name of the item.
        /// </summary>
        string UniqueName { get; }

        /// <summary>
        /// The weight of the item.
        /// </summary>
        float Weight { get; }

        /// <summary>
        /// If this item config has an associated equipment config.
        /// </summary>
        bool HasEquipmentConfig { get; }

        /// <summary>
        /// The config containing information about this item when worn as equipment.
        /// </summary>
        IEquipmentItemConfig EquipmentConfig { get; }

        /// <summary>
        /// The recipes for crafting this item.
        /// </summary>
        IItemRecipeConfig[] Recipes { get; }
    }
}
