using Ennui.Api.Object;
using Ennui.Api.Xml;
using Ennui.Api.Meta;
using Ennui.Api.Util;

namespace Ennui.Api
{
    /// <summary>
    /// Represents a drop from the mob that contains a harvestable.
    /// </summary>
    public class MobHarvestableDrop
    {
        private IApi api;
        private IMobObject parent;
        private IXmlHarvestableDrop dropConfig;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ennui.Api.Direct.Object.MobObject+MobHarvestableDrop"/> class.
        /// </summary>
        /// <param name="parent">The mob that has this drop.</param>
        /// <param name="drop">The drop config.</param>
        public MobHarvestableDrop(IApi api, IMobObject parent, IXmlHarvestableDrop dropConfig)
        {
            this.api = api;
            this.parent = parent;
            this.dropConfig = dropConfig;
        }

        /// <summary>
        /// Retrieves the type of harvestable that this drop is.
        /// </summary>
        /// <value>The type of harvestable that this drop is.</value>
        public ResourceType Type
        {
            get
            {
                var type = dropConfig.Type.Split('_')[0];
                switch (type)
                {
                    case "ROCK":
                        return ResourceType.Rock;
                    case "WOOD":
                        return ResourceType.Wood;
                    case "ORE":
                        return ResourceType.Ore;
                    case "HIDE":
                        return ResourceType.Hide;
                    case "FIBER":
                        return ResourceType.Fiber;
                    case "SILVERCOINS":
                        return ResourceType.Coins;
                    default:
                        api.Logging.Log("[MobHarvestableDrop#Type] Unknown resource type " + type, LogLevel.Info);
                        return ResourceType.Unknown;
                }
            }
        }

        /// <summary>
        /// Retrieves the tier of this harvestable drop.
        /// </summary>
        /// <value>The tier of this harvestable drop.</value>
        public int Tier
        {
            get
            {
                return dropConfig.Tier;
            }
        }

        /// <summary>
        /// The effective tier of this drop. For instance, a 4.2 resource
        /// will require a t4 tool to gather instead of a t3 tool, making it effectively
        /// a t5 resource.
        /// </summary>
        /// <value>The effective tier of the drop.</value>
        public int EffectiveTier
        {
            get
            {
                return api.Game.Sync(() =>
                {
                    var tier = Tier;
                    if (tier == -1) return -1;
                    var rarity = Rarity;
                    if (rarity != 0) tier += 1;
                    return tier;
                });
            }
        }

        /// <summary>
        /// Retrieves the rarity of this harvestable drop.
        /// </summary>
        /// <value>The rarity of this harvestable drop.</value>
        public int Rarity
        {
            get
            {
                return parent.RareState;
            }
        }
    }
}
