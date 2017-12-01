using System.Collections.Generic;

using Ennui.Api.Xml;

namespace Ennui.Api
{
    /// <summary>
    /// Holds context related to an expedition agent.
    /// </summary>
    public interface IExpeditionContext
    {
        /// <summary>
        /// The configs of all available expeditions.
        /// </summary>
        List<IExpeditionConfig> ExpeditionConfigs { get; }
    }
}
