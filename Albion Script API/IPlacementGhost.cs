using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
    /// Represents the ghost that's shown when a player
    /// is placing an object in the world.
    /// </summary>
    public interface IPlacementGhost
    {
        /// <summary>
        /// Updates the information in this ghost.
        /// </summary>
        /// <param name="item">The item being placed.</param>
        /// <param name="id">The id of the object being placed.</param>
        void Set(object item, long id);

        /// <summary>
        /// The rotation of this ghost. I'm not sure if it's euler angles or what, I forget.
        /// </summary>
        float Rotation { get; set; }

        /// <summary>
        /// The id of this ghost.
        /// </summary>
        long ObjectId { get; }

        /// <summary>
        /// The position of this ghost.
        /// </summary>
        IScenePosition Position { get; set; }
    }
}
