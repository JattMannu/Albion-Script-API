using System.Collections.Generic;

using Ennui.Api.Filter;
using Ennui.Api.Object;
using Ennui.Api.Util;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities relating to players.
	/// </summary>
    public interface IPlayers : IApiModule
    {
        /// <summary>
        /// The local player.
        /// </summary>
        ILocalPlayerObject LocalPlayer { get; }

        /// <summary>
        /// The local player's location.
        /// </summary>
        Vector3<float> LocalLocation { get; }

        /// <summary>
        /// The remote players in the currently loaded map region.
        /// </summary>
        List<IRemotePlayerObject> RemotePlayers { get; }

        /// <summary>
        /// A filter chain containing all remote players.
        /// </summary>
        RemotePlayerFilterChain RemotePlayerChain { get; }
    }
}
