using System.Collections.Generic;
using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
    public class ExpeditionExitFilterChain : SimulationFilterChain<IExpeditionExitObject, ExpeditionExitFilterChain>
    {
        public ExpeditionExitFilterChain(IApi api, List<IExpeditionExitObject> list) : base(api, list)
        {
        }

        protected override ExpeditionExitFilterChain Create(List<IExpeditionExitObject> elements)
        {
            return new ExpeditionExitFilterChain(Api, elements);
        }
    }
}
