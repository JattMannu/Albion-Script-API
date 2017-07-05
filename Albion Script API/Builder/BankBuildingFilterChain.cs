using System.Collections.Generic;
using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public class BankBuildingFilterChain : LocatableFilterChain<IBankBuildingObject, BankBuildingFilterChain>
	{
		public BankBuildingFilterChain(IApi api, List<IBankBuildingObject> list) : base(api, list)
		{

		}

		public override BankBuildingFilterChain Create(List<IBankBuildingObject> elements)
		{
			return new BankBuildingFilterChain(Api, elements);
		}
	}
}
