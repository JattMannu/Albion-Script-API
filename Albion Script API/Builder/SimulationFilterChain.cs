using System.Collections.Generic;
using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public abstract class SimulationFilterChain<T, R> : LocatableFilterChain<T, R> where T : ISimulationObject where R : FilterChain<T, R>
	{
		public SimulationFilterChain(IApi api, List<T> list) : base(api, list)
		{

		}

		public R ExcludeWithIds(params int[] ids)
		{
			return Filter(new ExludeWithIdsFilter<T>(ids));
		}

		public class ExludeWithIdsFilter<T> : Filter<T> where T : ISimulationObject
		{
			private int[] ids;

			public ExludeWithIdsFilter(params int[] ids)
			{
				this.ids = ids;
			}

			public bool Ignore(T t)
			{
				var id = t.Id;
				foreach (var cur in ids)
				{
					if (id == cur)
					{
						return true;
					}
				}
				return false;
			}
		}
	}
}

