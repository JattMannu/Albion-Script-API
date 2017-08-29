using System.Collections.Generic;
using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
    public class ExpeditionExitFilterChain : SimulationFilterChain<IExpeditionExit, ExpeditionExitFilterChain>
    {
        public ExpeditionExitFilterChain(IApi api, List<IExpeditionExit> list) : base(api, list)
        {
        }

        protected override ExpeditionExitFilterChain Create(List<IExpeditionExit> elements)
        {
            return new ExpeditionExitFilterChain(Api, elements);
        }
    }
}
