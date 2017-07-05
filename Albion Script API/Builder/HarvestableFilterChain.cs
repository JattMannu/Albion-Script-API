using System;
using System.Collections.Generic;
using Ennui.Api.Direct.Object;
using Ennui.Api.Meta;
using Ennui.Api.Method;

namespace Ennui.Api.Builder
{
	/// <summary>
	/// Handles filtering of HarvestableObjects.
	/// <see cref="HarvestableObject"/>
	/// </summary>
    public class HarvestableFilterChain : SimulationFilterChain<IHarvestableObject, HarvestableFilterChain>
    {
        public HarvestableFilterChain(IApi api, List<IHarvestableObject> list) : base(api, list)
        {
        }

		/// <summary>
		/// Finds the closest harvestable to the center position, sorted by the order of the provide
		/// type sets.
		/// </summary>
		/// <returns>The closest harvestable, sorted by the order of the provided type sets.</returns>
		/// <param name="center">The point to use when calculating distance between harvestables.</param>
		/// <param name="types">The type set ordering to use.</param>
		public IHarvestableObject SortedClosest(Vector3<float> center, params TypeSet[] types)
		{
			foreach (var type in types)
			{
				var filtered = FilterByTypeSet(types);
				var list = filtered.AsList;
				if (list.Count > 0)
				{
					return filtered.Closest(center);
				}
			}
			return null;
		}

		/// <summary>
		/// Filters by resource tier.
		/// </summary>
		/// <returns>A new filter chain containing only resources with the provided tier.</returns>
		/// <param name="tier">The tier to filter by.</param>
        public HarvestableFilterChain FilterByTier(int tier)
        {
			return Filter(new ExactTierFilter(tier));
        }

		public HarvestableFilterChain FilterByRarity(int min, int max)
		{
			return Filter(new RangeRarityFilter(min, max));
		}

		public HarvestableFilterChain FilterByTier(int min, int max)
		{
			return Filter(new RangeTierFilter(min, max));
		}

		public HarvestableFilterChain FilterByEffectiveTier(int min, int max)
		{
			return Filter(new RangeEffectiveTierFilter(min, max));
		}

		public HarvestableFilterChain FilterByType(params ResourceType[] types)
        {
            return Filter(new ResourceFilter(types));
        }

        public HarvestableFilterChain FilterDepleted()
        {
			return Filter(new DepletedFilter());
        }

		public HarvestableFilterChain FilterByHighestTier()
		{
			return Api.Game.Sync<HarvestableFilterChain>(() =>
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

		public HarvestableFilterChain FilterByTypeSet(params TypeSet[] types)
		{
			return Filter(new TypeSetFilter(types));
		}

		public HarvestableFilterChain FilterByEffectiveTypeSet(params TypeSet[] types)
		{
			return Filter(new EffectiveTypeSetFilter(types));
		}

        public class ExactTierFilter : Filter<IHarvestableObject>
        {
            private int tier;

            public ExactTierFilter(int tier)
            {
                this.tier = tier;
            }

            public bool Ignore(IHarvestableObject t)
            {
                return t.Tier != tier;
            }
        }

		public class RangeRarityFilter : Filter<IHarvestableObject>
		{
			private int min;
			private int max;

			public RangeRarityFilter(int min, int max)
			{
				this.min = min;
				this.max = max;
			}

			public bool Ignore(IHarvestableObject t)
			{
				var rarity = t.RareState;
				return rarity < min || rarity > max;
			}
		}

		public class RangeTierFilter : Filter<IHarvestableObject>
		{
			private int min;
			private int max;

			public RangeTierFilter(int min, int max)
			{
				this.min = min;
				this.max = max;
			}

			public bool Ignore(IHarvestableObject t)
			{
				var tier = t.Tier;
				return tier < min || tier > max;
			}
		}

		public class RangeEffectiveTierFilter : Filter<IHarvestableObject>
		{
			private int min;
			private int max;

			public RangeEffectiveTierFilter(int min, int max)
			{
				this.min = min;
				this.max = max;
			}

			public bool Ignore(IHarvestableObject t)
			{
				var tier = t.EffectiveTier;
				return tier < min || tier > max;
			}
		}

        public class ResourceFilter : Filter<IHarvestableObject>
        {
			private ResourceType[] types;

			public ResourceFilter(params ResourceType[] types)
            {
				this.types = types;
            }

            public bool Ignore(IHarvestableObject t)
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

        public class DepletedFilter : Filter<IHarvestableObject>
        {
            public bool Ignore(IHarvestableObject t)
            {
                return t.Depleted;
            }
        }

		public class TypeSetFilter: Filter<IHarvestableObject>
		{
			private TypeSet[] types;

			public TypeSetFilter(params TypeSet[] types)
			{
				this.types = types;
			}

			public bool Ignore(IHarvestableObject t)
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
								rarity = t.RareState;
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

		public class EffectiveTypeSetFilter: Filter<IHarvestableObject>
		{
			private TypeSet[] types;

			public EffectiveTypeSetFilter(params TypeSet[] types)
			{
				this.types = types;
			}

			public bool Ignore(IHarvestableObject t)
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

		public override HarvestableFilterChain Create(List<IHarvestableObject> elements)
		{
			return new HarvestableFilterChain(Api, elements);
		}
    }
}
