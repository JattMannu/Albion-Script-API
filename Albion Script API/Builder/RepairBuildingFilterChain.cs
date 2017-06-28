using System.Collections.Generic;
using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public class RepairBuildingFilterChain : LocatableFilterChain<IRepairBuildingObject, RepairBuildingFilterChain>
	{
		public RepairBuildingFilterChain(IApi api, List<IRepairBuildingObject> list) : base(api, list)
		{

		}

		public override RepairBuildingFilterChain Create(List<IRepairBuildingObject> elements)
		{
			return new RepairBuildingFilterChain(api, elements);
		}
	}
}
