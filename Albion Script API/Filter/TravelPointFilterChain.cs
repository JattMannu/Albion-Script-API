using System.Collections.Generic;

using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
	public class TravelPointFilterChain : LocatableFilterChain<ITravelPointObject, TravelPointFilterChain>
	{
		public TravelPointFilterChain(IApi api, List<ITravelPointObject> list) : base(api, list)
		{

		}

        protected override TravelPointFilterChain Create(List<ITravelPointObject> elements)
		{
			return new TravelPointFilterChain(Api, elements);
		}
	}
}
