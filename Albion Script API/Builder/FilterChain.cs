using System.Collections.Generic;
using Ennui.Api.Method;

namespace Ennui.Api.Builder
{
	public abstract class FilterChain<T, R> : ApiResource where R : FilterChain<T, R>
	{
		private List<T> list;

		public FilterChain(IApi api, List<T> list) : base(api)
		{
			this.list = list;
		}

		public R Filter(Filter<T> filter)
		{
			return Api.Game.Sync<R>(() =>
			{
				var tmp = new List<T>();
				foreach (T t in list)
				{
					if (!filter.Ignore(t))
					{
						tmp.Add(t);
					}
				}
				list = tmp;
				return Create(tmp);
			});
		}

		public List<T> AsList
		{
			get { return list; }
		}

		public T First
		{
			get
			{
				if (list.Count == 0)
					return default(T);
				else
					return list[0];
			}
		}

		public abstract R Create(List<T> elements);
	}
}
