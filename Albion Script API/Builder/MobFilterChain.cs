using System.Collections.Generic;
using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public class MobFilterChain : EntityFilterChain<IMobObject, MobFilterChain>
	{
		public MobFilterChain(IApi api, List<IMobObject> list) : base(api, list)
		{

		}

		public MobFilterChain FilterByRarity(int min, int max)
		{
			return Filter(new RangeRarityFilter(min, max));
		}

		public class RangeRarityFilter : Filter<IMobObject>
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

		public override MobFilterChain Create(List<IMobObject> elements)
		{
			return new MobFilterChain(api, elements);
		}

	}
}

