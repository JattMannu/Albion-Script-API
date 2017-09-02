using Ennui.Api.Object;
using System.Collections.Generic;

namespace Ennui.Api.Filter
{
    public class LootObjectFilterChain : LocatableFilterChain<ILootObject, LootObjectFilterChain>
    {
        public LootObjectFilterChain(IApi api, List<ILootObject> list) : base(api, list)
		{

        }

        protected override LootObjectFilterChain Create(List<ILootObject> elements)
        {
            return new LootObjectFilterChain(Api, elements);
        }
    }
}
