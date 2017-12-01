using System.Collections.Generic;

using Ennui.Api.Object;
using Ennui.Api.Meta;
using Ennui.Api.Util;

namespace Ennui.Api.Filter
{
    /// <summary>
    /// Provides filtering for harvesatble object types.
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
        /// Filters out harvestables with the provided setup state.
        /// </summary>
        /// <param name="state">The state to filter for.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
        public HarvestableFilterChain FilterWithSetupState(HarvestableSetupState state)
        {
            return Filter(new WithSetupStateFilter(state));
        }

        /// <summary>
        /// Filters out harvestables without the provided setup state.
        /// </summary>
        /// <param name="state">The state to filter for.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
        public HarvestableFilterChain FilterWithoutSetupState(HarvestableSetupState state)
        {
            return Filter(new WithoutSetupStateFilter(state));
        }

        /// <summary>
        /// Filters by resource tier.
        /// </summary>
        /// <param name="tier">The tier to filter by.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
        public HarvestableFilterChain FilterByTier(int tier)
        {
			return Filter(new ExactTierFilter(tier));
        }

        /// <summary>
        /// Filters out harvestables by their rarity.
        /// </summary>
        /// <param name="min">The minimum rarity to include.</param>
        /// <param name="max">The maximum rarity to include.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
		public HarvestableFilterChain FilterByRarity(int min, int max)
		{
			return Filter(new RangeRarityFilter(min, max));
		}

        /// <summary>
        /// Filters out harvestables by their tier.
        /// </summary>
        /// <param name="min">The minimum tier to include.</param>
        /// <param name="max">The maximum tier to include.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
		public HarvestableFilterChain FilterByTier(int min, int max)
		{
			return Filter(new RangeTierFilter(min, max));
		}

        /// <summary>
        /// Filters out harvestables by their effective tier.
        /// </summary>
        /// <param name="min">The minimum effective tier to include.</param>
        /// <param name="max">The maximum effective tier to include.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
		public HarvestableFilterChain FilterByEffectiveTier(int min, int max)
		{
			return Filter(new RangeEffectiveTierFilter(min, max));
		}

        /// <summary>
        /// Filters out harvestables by their types.
        /// </summary>
        /// <param name="types">The resource types to include.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
		public HarvestableFilterChain FilterByType(params ResourceType[] types)
        {
            return Filter(new ResourceFilter(types));
        }

        /// <summary>
        /// Filters out depleted harvestables.
        /// </summary>
        /// <returns>A chain containing the newly filtered elements.</returns>
        public HarvestableFilterChain FilterDepleted()
        {
			return Filter(new DepletedFilter());
        }

        /// <summary>
        /// Filters out harvestables by the tier of the highest tier harvestable.
        /// </summary>
        /// <returns>A chain containing the newly filtered elements.</returns>
		public HarvestableFilterChain FilterByHighestTier()
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

        /// <summary>
        /// Filters out harvestables using typesets.
        /// </summary>
        /// <param name="types">The typesets to filter with.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
        public HarvestableFilterChain FilterByTypeSet(params TypeSet[] types)
		{
			return Filter(new TypeSetFilter(types));
		}

        /// <summary>
        /// Filters out harvestables using typesets, with effective tiers.
        /// </summary>
        /// <param name="types">The typesets to filter with.</param>
        /// <returns>A chain containing the newly filtered elements.</returns>
        public HarvestableFilterChain FilterByEffectiveTypeSet(params TypeSet[] types)
		{
			return Filter(new EffectiveTypeSetFilter(types));
		}

        private class WithSetupStateFilter : Filter<IHarvestableObject>
        {
            private HarvestableSetupState state;

            public WithSetupStateFilter(HarvestableSetupState state)
            {
                this.state = state;
            }

            public bool Ignore(IHarvestableObject t)
            {
                return t.SetupState == state;
            }
        }

        private class WithoutSetupStateFilter : Filter<IHarvestableObject>
        {
            private HarvestableSetupState state;

            public WithoutSetupStateFilter(HarvestableSetupState state)
            {
                this.state = state;
            }

            public bool Ignore(IHarvestableObject t)
            {
                return t.SetupState != state;
            }
        }

        private class ExactTierFilter : Filter<IHarvestableObject>
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

        private class RangeRarityFilter : Filter<IHarvestableObject>
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

        private class RangeTierFilter : Filter<IHarvestableObject>
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

        private class RangeEffectiveTierFilter : Filter<IHarvestableObject>
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

        private class ResourceFilter : Filter<IHarvestableObject>
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

        private class DepletedFilter : Filter<IHarvestableObject>
        {
            public bool Ignore(IHarvestableObject t)
            {
                return t.Depleted;
            }
        }

        private class TypeSetFilter: Filter<IHarvestableObject>
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

        private class EffectiveTypeSetFilter: Filter<IHarvestableObject>
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

        protected override HarvestableFilterChain Create(List<IHarvestableObject> elements)
		{
			return new HarvestableFilterChain(Api, elements);
		}
    }
}
