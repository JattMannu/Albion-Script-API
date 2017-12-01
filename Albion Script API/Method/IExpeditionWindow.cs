using System.Collections.Generic;

using Ennui.Api.Xml;

namespace Ennui.Api.Method
{
    public interface IExpeditionWindow : IApiModule, IWidget
    {
        /// <summary>
        /// The configs of all expeditions provided by this agent.
        /// </summary>
        List<IExpeditionConfig> ExpeditionConfigs { get; }

        /// <summary>
        /// Enters the expedition with the provided config.
        /// </summary>
        /// <param name="expedition">The config of the expedition to enter.</param>
        void Enter(IExpeditionConfig expedition);
    }
}
