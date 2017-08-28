using System.Collections.Generic;

using Ennui.Api.Method;

namespace Ennui.Api.Filter
{
    /// <summary>
    /// Provides chained method filtering on a list of objects.
    /// </summary>
    /// <typeparam name="T">The type of value we're filtering.</typeparam>
    /// <typeparam name="R">The type to return for method chaining.</typeparam>
	public abstract class FilterChain<T, R> : ApiResource where R : FilterChain<T, R>
	{
		private List<T> list;

		public FilterChain(IApi api, List<T> list) : base(api)
		{
			this.list = list;
		}

        /// <summary>
        /// Filters the list using the provided filter, and returns a new chain
        /// containing the filtered elements.
        /// </summary>
        /// <param name="filter">The filter to pass all values through.</param>
        /// <returns>The new chain, containing the new items.</returns>
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

        /// <summary>
        /// The values inside of this chain.
        /// </summary>
		public List<T> AsList
		{
			get { return list; }
		}

        /// <summary>
        /// The first item inside of this chain, or <code>null</code> if no value is present.
        /// </summary>
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

        /// <summary>
        /// Creates a new chain of this type using the provided values.
        /// </summary>
        /// <param name="elements">The values to populate the chain with.</param>
        /// <returns>The newly created chain</returns>
		protected abstract R Create(List<T> elements);
	}
}
