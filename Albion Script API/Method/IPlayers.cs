using Ennui.Api.Builder;
using Ennui.Api.Direct.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities relating to players.
	/// </summary>
    public interface IPlayers : IApiModule
    {
        /// <summary>
        /// Gets the local player.
        /// </summary>
        /// <value>The local player.</value>
        ILocalPlayerObject LocalPlayer { get; }

        /// <summary>
        /// Gets the local player's location.
        /// </summary>
        /// <value>The local player's location.</value>
        Vector3<float> LocalLocation { get; }

        /// <summary>
        /// Gets all of the remote players in the currently loaded map region.
        /// </summary>
        /// <value>The remote players in the currently loaded map region.</value>
        List<IRemotePlayerObject> RemotePlayers { get; }

        RemotePlayerFilterChain RemotePlayerChain { get; }
    }
}
