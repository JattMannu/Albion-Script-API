using System.Collections.Generic;

using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
	public class BankBuildingFilterChain : LocatableFilterChain<IBankBuildingObject, BankBuildingFilterChain>
	{
		public BankBuildingFilterChain(IApi api, List<IBankBuildingObject> list) : base(api, list)
		{

		}

        protected override BankBuildingFilterChain Create(List<IBankBuildingObject> elements)
		{
			return new BankBuildingFilterChain(Api, elements);
		}
	}
}
