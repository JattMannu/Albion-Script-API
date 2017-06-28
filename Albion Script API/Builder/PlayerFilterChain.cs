using System.Collections.Generic;
using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public abstract class PlayerFilterChain<T, R> : EntityFilterChain<T, R> where T : IPlayerObject where R : FilterChain<T, R>
	{
		public PlayerFilterChain(IApi api, List<T> list) : base(api, list)
		{

		}

		public R FilterByPvpEnabled(bool enabled)
		{
			return Filter(new PvpEnabledFilter<T>(enabled));
		}

		public R FilterByMounted(bool mounted)
		{
			return Filter(new MountedFilter<T>(mounted));
		}

		public R FilterByGuildTag(string guild)
		{
			return Filter(new GuildFilter<T>(guild));
		}

		public R FilterByGuild(string guild)
		{
			return Filter(new GuildFilter<T>(guild));
		}

		public class PvpEnabledFilter<T> : Filter<T> where T : IPlayerObject
		{
			private bool pvpEnabled;

			public PvpEnabledFilter(bool pvpEnabled)
			{
				this.pvpEnabled = pvpEnabled;
			}

			public bool Ignore(T t)
			{
				return pvpEnabled != t.IsPvpEnabled;
			}
		}

		public class MountedFilter<T> : Filter<T> where T : IPlayerObject
		{
			private bool mounted;

			public MountedFilter(bool mounted)
			{
				this.mounted = mounted;
			}

			public bool Ignore(T t)
			{
				return mounted != t.IsMounted;
			}
		}


		public class GuildTagFilter<T> : Filter<T> where T : IPlayerObject
		{
			private string tag;

			public GuildTagFilter(string tag)
			{
				this.tag = tag;
			}

			public bool Ignore(T t)
			{
				return !t.GuildTag.Equals(this.tag);
			}
		}

		public class GuildFilter<T> : Filter<T> where T : IPlayerObject
		{
			private string guild;

			public GuildFilter(string guild)
			{
				this.guild = guild;
			}

			public bool Ignore(T t)
			{
				return !t.Guild.Equals(this.guild);
			}
		}

	}
}

