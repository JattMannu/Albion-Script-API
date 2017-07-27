using Ennui.Api.Direct.Xml;
using System.Collections.Generic;

namespace Ennui.Api.Direct
{
    /// <summary>
    /// Holds context related to an expedition agent.
    /// </summary>
    public interface IExpeditionContext
    {
        /// <summary>
        /// The configs of all available expeditions.
        /// </summary>
        List<IXmlExpedition> ExpeditionConfigs { get; }
    }
}
