using Ennui.Api.Builder;
using Ennui.Api.Direct.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    public interface IEntities : IApiModule
    {
        /// <summary>
        /// Gets a list of all entities within the currently loaded map region.
        /// </summary>
        /// <value>A list of all entities within the currently loaded map region.</value>
        List<IEntityObject> All { get; }

        /// <summary>
        /// Creates an EntityFilterChain containing every Entity within the scene.
        /// </summary>
        /// <value>A EntityFilterChain containing every Entity within the scene.</value>
        ConcreteEntityFilterChain Chain { get; }

        /// <summary>
        /// Gets a list of all Mobs within the currently loaded map region.
        /// </summary>
        /// <value>A list of all Mobs within the currently loaded map region.</value>
        List<IMobObject> Mobs { get; }

        /// <summary>
        /// Creates a MobfilterChain containing every Mob within the scene.
        /// </summary>
        /// <value>A MobfilterChain containing every Mob within the scene.</value>
        MobFilterChain MobChain { get; }

        /// <summary>
        /// Gets a list of all Mounts within the currently loaded map region.
        /// </summary>
        /// <value>A list of all Mounts within the currently loaded map region.</value>
        List<IMountObject> Mounts { get; }

        /// <summary>
        /// Attempts to find the local player's mount.
        /// </summary>
        /// <value>Our mount, or null if we don't have one within the scene.</value>
        IMountObject OurMount { get; }
    }
}
