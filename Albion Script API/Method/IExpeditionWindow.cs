using Ennui.Api.Direct.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    public interface IExpeditionWindow
    {
        /// <summary>
        /// The configs of all expeditions provided by this agent.
        /// </summary>
        List<IXmlExpedition> ExpeditionConfigs { get; }

        /// <summary>
        /// Enters the expedition with the provided config.
        /// </summary>
        /// <param name="expedition">The config of the expedition to enter.</param>
        void Enter(IXmlExpedition expedition);
    }
}
