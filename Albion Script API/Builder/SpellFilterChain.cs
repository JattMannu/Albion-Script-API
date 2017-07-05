using System.Collections.Generic;

using Ennui.Api.Direct;
using Ennui.Api.Meta;

namespace Ennui.Api.Builder
{
	public class SpellFilterChain : FilterChain<ISpell, SpellFilterChain>
	{
		public SpellFilterChain(IApi api, List<ISpell> list) : base(api, list)
		{

		}

		public SpellFilterChain FilterNulls()
		{
			return Filter(new NullFilter());
		}

		public SpellFilterChain FilterByReady()
		{
			return Filter(new ReadyToCastFilter());
		}

		public SpellFilterChain FilterByCategory(SpellCategory category)
		{
			return Filter(new CategoryFilter(category));
		}

		public SpellFilterChain FilterByTarget(SpellTarget target)
		{
			return Filter(new TargetFilter(target));
		}

		public SpellFilterChain ExcludeWithoutName(params string[] names)
		{
			return Filter(new ExcludeWithoutNameFilter(names));
		}

		public SpellFilterChain ExcludeWithName(params string[] names)
		{
			return Filter(new ExcludeWithNameFilter(names));
		}

		public override SpellFilterChain Create(List<ISpell> elements)
		{
			return new SpellFilterChain(Api, elements);
		}

		public class NullFilter : Filter<ISpell>
		{
			public bool Ignore(ISpell t)
			{
                if (t == null || !t.InUse)
                    return true;

                return t == null;
			}
		}

		public class ReadyToCastFilter : Filter<ISpell>
		{
			public bool Ignore(ISpell t)
			{
                if (t == null || !t.InUse)
                    return true;

                return !t.IsReadyToCast;
			}
		}

		public class CategoryFilter : Filter<ISpell>
		{
			private SpellCategory category;

			public CategoryFilter(SpellCategory category)
			{
				this.category = category;
			}

			public bool Ignore(ISpell t)
			{
                if (t == null || !t.InUse)
                    return true;

                return t.Category != this.category;
			}
		}

		public class TargetFilter : Filter<ISpell>
		{
			private SpellTarget target;

			public TargetFilter(SpellTarget target)
			{
				this.target = target;
			}

			public bool Ignore(ISpell t)
			{
                if (t == null || !t.InUse)
                    return true;

                return t.Target != this.target;
			}
		}

		public class ExcludeWithoutNameFilter : Filter<ISpell>
		{
			private string[] names;

			public ExcludeWithoutNameFilter(params string[] names)
			{
				this.names = names;
			}

			public bool Ignore(ISpell t)
			{
                if (t == null || !t.InUse)
                    return true;

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

		public class ExcludeWithNameFilter : Filter<ISpell>
		{
			private string[] names;

			public ExcludeWithNameFilter(params string[] names)
			{
				this.names = names;
			}

			public bool Ignore(ISpell t)
			{
                if (t == null || !t.InUse)
                    return true; 

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

