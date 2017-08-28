using System.Collections.Generic;

using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
	public abstract class EntityFilterChain<T, R> : SimulationFilterChain<T, R> where T : IEntityObject where R : FilterChain<T, R>
	{
		public EntityFilterChain(IApi api, List<T> list) : base(api, list)
		{

		}

		public R ExcludeWithoutName(params string[] names)
		{
			return Filter(new ExcludeWithoutNameFilter<T>(names));
		}

		public R ExcludeWithoutNameSubstring(params string[] names)
		{
			return Filter(new ExludeWithoutNameSusbtringFilter<T>(names));
		}

		public R ExcludeWithName(params string[] names)
		{
			return Filter(new ExcludeWithNameFilter<T>(names));
		}

		public R ExcludeWithNameSubstring(params string[] names)
		{
			return Filter(new ExludeWithNameSusbtringFilter<T>(names));
		}

		public class ExcludeWithoutNameFilter<T> : Filter<T> where T : IEntityObject
		{
			private string[] names;

			public ExcludeWithoutNameFilter(params string[] name)
			{
				this.names = name;
			}

			public bool Ignore(T t)
			{
				string name = t.Name;
				foreach (string cur in names)
				{
					if (name.Equals(cur))
					{
						return false;
					}
				}
				return true;
			}
		}

		public class ExludeWithoutNameSusbtringFilter<T> : Filter<T> where T : IEntityObject
		{
			private string[] names;

			public ExludeWithoutNameSusbtringFilter(string[] names)
			{
				this.names = names;
			}

			public bool Ignore(T t)
			{
				string name = t.Name;
				foreach (string cur in names)
				{
					if (name.Contains(cur))
					{
						return false;
					}
				}
				return true;
			}
		}

		public class ExcludeWithNameFilter<T> : Filter<T> where T : IEntityObject
		{
			private string[] names;

			public ExcludeWithNameFilter(params string[] name)
			{
				this.names = name;
			}

			public bool Ignore(T t)
			{
				string name = t.Name;
				foreach (string cur in names)
				{
					if (name.Equals(cur))
					{
						return true;
					}
				}
				return false;
			}
		}

		public class ExludeWithNameSusbtringFilter<T> : Filter<T> where T : IEntityObject
		{
			private string[] names;

			public ExludeWithNameSusbtringFilter(string[] names)
			{
				this.names = names;
			}

			public bool Ignore(T t)
			{
				string name = t.Name;
				foreach (string cur in names)
				{
					if (name.Contains(cur))
					{
						return true;
					}
				}
				return false;
			}
		}
	}
}

