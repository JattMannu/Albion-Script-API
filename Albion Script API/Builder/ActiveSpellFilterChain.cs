using System.Collections.Generic;

using Ennui.Api.Direct;

namespace Ennui.Api.Builder
{
	public class ActiveSpellFilterChain : FilterChain<IActiveSpell, ActiveSpellFilterChain>
	{
		public ActiveSpellFilterChain(IApi api, List<IActiveSpell> list) : base(api, list)
		{

		}

		public ActiveSpellFilterChain ExcludeWithoutName(params string[] names)
		{
			return Filter(new ExcludeWithoutNameFilter(names));
		}

		public ActiveSpellFilterChain ExcludeWithName(params string[] names)
		{
			return Filter(new ExcludeWithNameFilter(names));
		}

		public override ActiveSpellFilterChain Create(List<IActiveSpell> elements)
		{
			return new ActiveSpellFilterChain(Api, elements);
		}

		public class ExcludeWithoutNameFilter : Filter<IActiveSpell>
		{
			private string[] names;

			public ExcludeWithoutNameFilter(params string[] names)
			{
				this.names = names;
			}

			public bool Ignore(IActiveSpell t)
			{
				var name = t.Name;
				foreach (var cur in names)
				{
					if (cur.Equals(name))
					{
						return false;
					}
				}
				return true;
			}
		}

		public class ExcludeWithNameFilter : Filter<IActiveSpell>
		{
			private string[] names;

			public ExcludeWithNameFilter(params string[] names)
			{
				this.names = names;
			}

			public bool Ignore(IActiveSpell t)
			{
				var name = t.Name;
				foreach (var cur in names)
				{
					if (cur.Equals(name))
					{
						return true;
					}
				}
				return false;
			}
		}
	}
}

