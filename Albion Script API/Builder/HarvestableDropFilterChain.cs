using Ennui.Api.Direct.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Builder
{
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
            return Api.Game.Sync<HarvestableDropFilterChain>(() =>
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
            return new HarvestableDropFilterChain(Api, elements);
        }
    }
}
