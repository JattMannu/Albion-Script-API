using System.Collections.Generic;

using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
    /// <summary>
    /// Provides filtering for mobs.
    /// </summary>
	public class MobFilterChain : EntityFilterChain<IMobObject, MobFilterChain>
	{
		public MobFilterChain(IApi api, List<IMobObject> list) : base(api, list)
		{

		}

        /// <summary>
        /// Filters out mobs that aren't in the provided rarity range.
        /// </summary>
        /// <param name="min">The minimum rarity to filter for.</param>
        /// <param name="max">The maximum rarity to filter  for.</param>
        /// <returns>The filtered values in a new chain.</returns>
		public MobFilterChain FilterByRarity(int min, int max)
		{
			return Filter(new RangeRarityFilter(min, max));
		}

        protected override MobFilterChain Create(List<IMobObject> elements)
		{
			return new MobFilterChain(Api, elements);
		}

        private class RangeRarityFilter : Filter<IMobObject>
        {
            private int min;
            private int max;

            public RangeRarityFilter(int min, int max)
            {
                this.min = min;
                this.max = max;
            }

            public bool Ignore(IMobObject t)
            {
                var rarity = t.RareState;
                return rarity < min || rarity > max;
            }
        }

    }
}

