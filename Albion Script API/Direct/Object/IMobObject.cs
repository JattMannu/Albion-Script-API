using Ennui.Api.Builder;
using Ennui.Api.Direct.Xml;
using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
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
        /// Retrieves this mob's xml config.
        /// </summary>
        /// <value>This mob's xml config.</value>
         IXmlMob MobXmlConfig { get; }

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

         HarvestableDropFilterChain HarvestableDropChain { get; }
    }

    public class HarvestableDropFilterChain : FilterChain<MobHarvestableDrop, HarvestableDropFilterChain>
    {
        public HarvestableDropFilterChain(IApi api, List<MobHarvestableDrop> list) : base(api, list)
        {
        }

        public HarvestableDropFilterChain FilterByTier(int tier)
        {
            return Filter(new ExactTierFilter(tier));
        }

        public HarvestableDropFilterChain FilterByRarity(int min, int max)
        {
            return Filter(new RangeRarityFilter(min, max));
        }

        public HarvestableDropFilterChain FilterByTier(int min, int max)
        {
            return Filter(new RangeTierFilter(min, max));
        }

        public HarvestableDropFilterChain FilterByEffectiveTier(int min, int max)
        {
            return Filter(new RangeEffectiveTierFilter(min, max));
        }

        public HarvestableDropFilterChain FilterByType(params ResourceType[] types)
        {
            return Filter(new ResourceFilter(types));
        }

        public HarvestableDropFilterChain FilterByHighestTier()
        {
            return api.Game.Sync< HarvestableDropFilterChain>(() =>
            {
                var highest = 0;
                foreach (var obj in AsList)
                {
                    var tier = obj.Tier;
                    if (tier >= highest)
                    {
                        highest = tier;
                    }
                }
                return FilterByTier(highest);
            });
        }

        public HarvestableDropFilterChain FilterByTypeSet(params TypeSet[] types)
        {
            return Filter(new TypeSetFilter(types));
        }

        public HarvestableDropFilterChain FilterByEffectiveTypeSet(params TypeSet[] types)
        {
            return Filter(new EffectiveTypeSetFilter(types));
        }

        public class ExactTierFilter : Filter<MobHarvestableDrop>
        {
            private int tier;

            public ExactTierFilter(int tier)
            {
                this.tier = tier;
            }

            public bool Ignore(MobHarvestableDrop t)
            {
                return t.Tier != tier;
            }
        }

        public class RangeRarityFilter : Filter<MobHarvestableDrop>
        {
            private int min;
            private int max;

            public RangeRarityFilter(int min, int max)
            {
                this.min = min;
                this.max = max;
            }

            public bool Ignore(MobHarvestableDrop t)
            {
                var rarity = t.Rarity;
                return rarity < min || rarity > max;
            }
        }

        public class RangeTierFilter : Filter<MobHarvestableDrop>
        {
            private int min;
            private int max;

            public RangeTierFilter(int min, int max)
            {
                this.min = min;
                this.max = max;
            }

            public bool Ignore(MobHarvestableDrop t)
            {
                var tier = t.Tier;
                return tier < min || tier > max;
            }
        }

        public class RangeEffectiveTierFilter : Filter<MobHarvestableDrop>
        {
            private int min;
            private int max;

            public RangeEffectiveTierFilter(int min, int max)
            {
                this.min = min;
                this.max = max;
            }

            public bool Ignore(MobHarvestableDrop t)
            {
                var tier = t.EffectiveTier;
                return tier < min || tier > max;
            }
        }

        public class ResourceFilter : Filter<MobHarvestableDrop>
        {
            private ResourceType[] types;

            public ResourceFilter(params ResourceType[] types)
            {
                this.types = types;
            }

            public bool Ignore(MobHarvestableDrop t)
            {
                var type = t.Type;
                foreach (ResourceType rt in types)
                {
                    if (type == rt)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public class TypeSetFilter : Filter<MobHarvestableDrop>
        {
            private TypeSet[] types;

            public TypeSetFilter(params TypeSet[] types)
            {
                this.types = types;
            }

            public bool Ignore(MobHarvestableDrop t)
            {
                var type = t.Type;
                var tier = 0;
                var rarity = 0;
                var gotTier = false;
                var gotRarity = false;

                foreach (var tset in types)
                {
                    if (type == tset.Type)
                    {
                        if (!gotTier)
                        {
                            gotTier = true;
                            tier = t.Tier;
                        }

                        if (tier >= tset.MinTier && tier <= tset.MaxTier)
                        {
                            if (!gotRarity)
                            {
                                gotRarity = true;
                                rarity = t.Rarity;
                            }

                            if (rarity >= tset.MinRarity && rarity <= tset.MaxRarity)
                            {
                                return false;
                            }
                        }

                    }
                }
                return true;
            }
        }

        public class EffectiveTypeSetFilter : Filter<MobHarvestableDrop>
        {
            private TypeSet[] types;

            public EffectiveTypeSetFilter(params TypeSet[] types)
            {
                this.types = types;
            }

            public bool Ignore(MobHarvestableDrop t)
            {
                var type = t.Type;
                var tier = t.EffectiveTier;
                foreach (var tset in types)
                {
                    if (type == tset.Type && tier >= tset.MinTier && tier <= tset.MaxTier)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public override HarvestableDropFilterChain Create(List<MobHarvestableDrop> elements)
        {
            return new HarvestableDropFilterChain(api, elements);
        }
    }

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
