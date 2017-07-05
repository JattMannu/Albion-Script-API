using System.Collections.Generic;
using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public class TravelPointFilterChain : LocatableFilterChain<ITravelPointObject, TravelPointFilterChain>
	{
		public TravelPointFilterChain(IApi api, List<ITravelPointObject> list) : base(api, list)
		{

		}

		public override TravelPointFilterChain Create(List<ITravelPointObject> elements)
		{
			return new TravelPointFilterChain(Api, elements);
		}
	}
}
