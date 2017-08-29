using System.Collections.Generic;

using Ennui.Api.Filter;
using Ennui.Api.Xml;
using Ennui.Api.Meta;

namespace Ennui.Api.Object
{
    /// <summary>
    /// Represents a mob in the game scene.
    /// </summary>
    public interface IMobObject : IEntityObject
    {
        /// <summary>
        /// Retrieves this mob's rare state.
        /// </summary>
        /// <value>This mob's rare state.</value>
        int RareState { get; }

        /// <summary>
        /// Retrieves a list of harvestables that this mob drops.
        /// </summary>
        /// <value>A list of harvestables that this mob drops.</value>
        List<MobHarvestableDrop> HarvestableDrops { get; }

        /// <summary>
        /// Retrieves a list of items that this mob drops.
        /// </summary>
        /// <value>A list of items that this mob drops.</value>
        List<IXmlItemDrop> ItemDrops { get; }

        /// <summary>
        /// All of this mob's drops in a chain.
        /// </summary>
        HarvestableDropFilterChain HarvestableDropChain { get; }

        /// <summary>
        /// This mob's attack type.
        /// </summary>
        AttackType AttackType { get; }
    }
}
