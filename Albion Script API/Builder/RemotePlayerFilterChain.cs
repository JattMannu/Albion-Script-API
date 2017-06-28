using System.Collections.Generic;
using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public class RemotePlayerFilterChain : PlayerFilterChain<IRemotePlayerObject, RemotePlayerFilterChain>
	{
		public RemotePlayerFilterChain(IApi api, List<IRemotePlayerObject> list) : base(api, list)
		{

		}

		public RemotePlayerFilterChain FilterByLocalParty(bool inLocalParty)
		{
			return Filter(new LocalPartyFilter(inLocalParty));
		}

		public class LocalPartyFilter : Filter<IRemotePlayerObject>
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

		public override RemotePlayerFilterChain Create(List<IRemotePlayerObject> elements)
		{
			return new RemotePlayerFilterChain(api, elements);
		}

	}
}

