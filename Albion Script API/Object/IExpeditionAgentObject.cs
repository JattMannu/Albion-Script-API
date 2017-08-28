using System.Collections.Generic;

using Ennui.Api.Xml;

namespace Ennui.Api.Object
{
    /// <summary>
    /// Represents the agent that gives out expedition quests.
    /// </summary>
    public interface IExpeditionAgentObject : IWorldObject
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
