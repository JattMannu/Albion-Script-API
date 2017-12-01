using Ennui.Api.Object;
using System.Collections.Generic;

namespace Ennui.Api.Filter
{
    public class SpellEffectAreaFilterChain : SimulationFilterChain<ISpellEffectAreaObject, SpellEffectAreaFilterChain>
    {
        public SpellEffectAreaFilterChain(IApi api, List<ISpellEffectAreaObject> list) : base(api, list)
        {
        }

        protected override SpellEffectAreaFilterChain Create(List<ISpellEffectAreaObject> elements)
        {
            return new SpellEffectAreaFilterChain(Api, elements);
        }
    }
}
