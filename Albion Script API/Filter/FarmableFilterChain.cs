using Ennui.Api.Object;
using System.Collections.Generic;

namespace Ennui.Api.Filter
{
    public class FarmableFilterChain : LocatableFilterChain<IFarmableObject, FarmableFilterChain>
    {
        public FarmableFilterChain(IApi api, List<IFarmableObject> list) : base(api, list)
		{

        }

        protected override FarmableFilterChain Create(List<IFarmableObject> elements)
        {
            return new FarmableFilterChain(Api, elements);
        }
    }
}
