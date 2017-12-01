using Ennui.Api.Object;
using System.Collections.Generic;

namespace Ennui.Api.Filter
{
    public  class TeleportStoneFilterChain : SimulationFilterChain<ITeleportStoneObject, TeleportStoneFilterChain>
    {
        public TeleportStoneFilterChain(IApi api, List<ITeleportStoneObject> list) : base(api, list)
        {
        }

        protected override TeleportStoneFilterChain Create(List<ITeleportStoneObject> elements)
        {
            return new TeleportStoneFilterChain(Api, elements);
        }
    }
}
