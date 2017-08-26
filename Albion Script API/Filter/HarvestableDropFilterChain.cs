using System.Collections.Generic;

using Ennui.Api.Meta;

namespace Ennui.Api.Filter
{
    /// <summary>
    /// Provides filtering for harvestables.
    /// </summary>
    public class HarvestableDropFilterChain : FilterChain<MobHarvestableDrop, HarvestableDropFilterChain>
    {
        public HarvestableDropFilterChain(IApi api, List<MobHarvestableDrop> list) : base(api, list)
        {
        }

        /// <summary>
        /// Filters harvestables by their tier.
        /// </summary>
        /// <param name="tier">The tier to filter for.</param>
        /// <returns>The filtered values in a new chain.</returns>
        public HarvestableDropFilterChain FilterByTier(int tier)
        {
            return Filter(new ExactTierFilter(tier));
        }

        /// <summary>
        /// Filters harvestables by their rarity.
        /// </summary>
        /// <param name="min">The min rarity to filter by.</param>
        /// <param name="max">The max rarity to filter by.</param>
        /// <returns>The filtered values in a new chain.</returns>
        public HarvestableDropFilterChain FilterByRarity(int min, int max)
        {
            return Filter(new RangeRarityFilter(min, max));
        }

        /// <summary>
        /// Filters harvestables by their tier.
        /// </summary>
        /// <param name="min">The min tier to filter for.</param>
        /// <param name="max">The max tier to filter for.</param>
        /// <returns>The filtered values in a new chain.</returns>
        public HarvestableDropFilterChain FilterByTier(int min, int max)
        {
            return Filter(new RangeTierFilter(min, max));
        }

        /// <summary>
        /// Filters harvestables by their effective tier.
        /// </summary>
        /// <param name="min">The min tier to filter for.</param>
        /// <param name="max">The max tier to filter for.</param>
        /// <returns>The filtered values in a new chain.</returns>
        public HarvestableDropFilterChain FilterByEffectiveTier(int min, int max)
        {
            return Filter(new RangeEffectiveTierFilter(min, max));
        }

        /// <summary>
        /// Filters harvestables by their type.
        /// </summary>
        /// <param name="types">The types to filter by.</param>
        /// <returns>The filteres values in a new chain.</returns>
        public HarvestableDropFilterChain FilterByType(params ResourceType[] types)
        {
            return Filter(new ResourceFilter(types));
        }

        public HarvestableDropFilterChain FilterByHighestTier()
        {
            return Game.Sync(() =>
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

        protected override HarvestableDropFilterChain Create(List<MobHarvestableDrop> elements)
        {
            return new HarvestableDropFilterChain(Api, elements);
        }

        private class ExactTierFilter : Filter<MobHarvestableDrop>
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

        private class RangeRarityFilter : Filter<MobHarvestableDrop>
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

        private class RangeTierFilter : Filter<MobHarvestableDrop>
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

        private class RangeEffectiveTierFilter : Filter<MobHarvestableDrop>
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

        private class ResourceFilter : Filter<MobHarvestableDrop>
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

        private class TypeSetFilter : Filter<MobHarvestableDrop>
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

        private class EffectiveTypeSetFilter : Filter<MobHarvestableDrop>
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
    }
}
