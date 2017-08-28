using System.Collections.Generic;

using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
    /// <summary>
    /// Provides filtering for remote players.
    /// </summary>
	public class RemotePlayerFilterChain : PlayerFilterChain<IRemotePlayerObject, RemotePlayerFilterChain>
    {
        public RemotePlayerFilterChain(IApi api, List<IRemotePlayerObject> list) : base(api, list)
        {

        }

        /// <summary>
        /// Filters players by whether or not they're in the local player's party.
        /// </summary>
        /// <param name="inLocalParty">The flag to filter for.</param>
        /// <returns>The filtered values in a new chain</returns>
		public RemotePlayerFilterChain FilterByLocalParty(bool inLocalParty)
        {
            return Filter(new LocalPartyFilter(inLocalParty));
        }

        protected override RemotePlayerFilterChain Create(List<IRemotePlayerObject> elements)
        {
            return new RemotePlayerFilterChain(Api, elements);
        }

        private class LocalPartyFilter : Filter<IRemotePlayerObject>
        {
            private bool inLocalParty;

            public LocalPartyFilter(bool inLocalParty)
            {
                this.inLocalParty = inLocalParty;
            }

            public bool Ignore(IRemotePlayerObject t)
            {
                return inLocalParty != t.IsInLocalPlayerParty;
            }
        }

    }
}

