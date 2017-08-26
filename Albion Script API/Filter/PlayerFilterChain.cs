using System.Collections.Generic;

using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
    /// <summary>
    /// Provides filtering for players.
    /// </summary>
    /// <typeparam name="T">The type of player to filter.</typeparam>
    /// <typeparam name="R">The chain type to return for chained method calling.</typeparam>
	public abstract class PlayerFilterChain<T, R> : EntityFilterChain<T, R> where T : IPlayerObject where R : FilterChain<T, R>
    {
        public PlayerFilterChain(IApi api, List<T> list) : base(api, list)
        {

        }

        /// <summary>
        /// Filters players by whether or not they have pvp enabled.
        /// </summary>
        /// <param name="enabled">The flag to filter for.</param>
        /// <returns>The filtered values in a new chain.</returns>
		public R FilterByPvpEnabled(bool enabled)
        {
            return Filter(new PvpEnabledFilter<T>(enabled));
        }

        /// <summary>
        /// Filters players by whether or not they're mounted.
        /// </summary>
        /// <param name="mounted">The flag to filter for.</param>
        /// <returns>The filtered values in a new chain.</returns>
        public R FilterByMounted(bool mounted)
        {
            return Filter(new MountedFilter<T>(mounted));
        }

        /// <summary>
        /// Filters players by their guild tag.
        /// </summary>
        /// <param name="guild">The guild tag to filter for.</param>
        /// <returns>The filtered values in a new chain.</returns>
		public R FilterByGuildTag(string guild)
        {
            return Filter(new GuildFilter<T>(guild));
        }

        /// <summary>
        /// Filters players by their guild name.
        /// </summary>
        /// <param name="guild">The guild name to search for.</param>
        /// <returns>The filtered values in a new chain.</returns>
		public R FilterByGuild(string guild)
        {
            return Filter(new GuildFilter<T>(guild));
        }

        private class PvpEnabledFilter<T> : Filter<T> where T : IPlayerObject
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

        private class MountedFilter<T> : Filter<T> where T : IPlayerObject
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

        private class GuildTagFilter<T> : Filter<T> where T : IPlayerObject
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

        private class GuildFilter<T> : Filter<T> where T : IPlayerObject
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

