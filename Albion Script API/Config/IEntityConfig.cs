using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Config
{
    /// <summary>
    /// Contains configuration information about an entity.
    /// </summary>
    public interface IEntityConfig
    {
        /// <summary>
        /// The stats of the entity.
        /// </summary>
        float[] Stats { get; }

        /// <summary>
        /// The collision radius of the entity.
        /// </summary>
        float CollisionRadius { get; }

        /// <summary>
        /// The collision radius of the entity's attack.
        /// </summary>
        float AttackCollisionRadius { get; }
    }
}
