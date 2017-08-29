using Ennui.Api.Object;
using System.Collections.Generic;

namespace Ennui.Api.Filter
{
    public class HellgateFilterChain : SimulationFilterChain<IHellgateObject, HellgateFilterChain>
    {
        public HellgateFilterChain(IApi api, List<IHellgateObject> list) : base(api, list)
        {
        }

        protected override HellgateFilterChain Create(List<IHellgateObject> elements)
        {
            return new HellgateFilterChain(Api, elements);
        }
    }
}
