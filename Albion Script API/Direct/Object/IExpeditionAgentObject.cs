using Ennui.Api.Direct.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
    /// Represents the agent that gives out expedition quests.
    /// </summary>
    public interface IExpeditionAgentObject
    {
        /// <summary>
        /// The context of this agent.
        /// </summary>
        IExpeditionContext ExpeditionContext { get; }

        /// <summary>
        /// The configs of all expeditions provided by this agent.
        /// </summary>
        List<IXmlExpedition> ExpeditionConfigs { get; }
    }
}
