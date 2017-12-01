using Ennui.Api.Object;
using System.Collections.Generic;

namespace Ennui.Api.Filter
{
    public class ExpeditionAgentFilterChain : SimulationFilterChain<IExpeditionAgentObject, ExpeditionAgentFilterChain>
    {
        public ExpeditionAgentFilterChain(IApi api, List<IExpeditionAgentObject> list) : base(api, list)
        {
        }

        protected override ExpeditionAgentFilterChain Create(List<IExpeditionAgentObject> elements)
        {
            return new ExpeditionAgentFilterChain(Api, elements);
        }
    }
}
