using Ennui.Api.Object;
using System.Collections.Generic;

namespace Ennui.Api.Filter
{
    public class SilverFilterChain : SimulationFilterChain<ISilverObject, SilverFilterChain>
    {
        public SilverFilterChain(IApi api, List<ISilverObject> list) : base(api, list)
        {
        }

        protected override SilverFilterChain Create(List<ISilverObject> elements)
        {
            return new SilverFilterChain(Api, elements);
        }
    }
}
