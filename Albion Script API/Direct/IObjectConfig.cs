using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
	/// Contains scene information about an object.
	/// </summary>
    public interface IObjectConfig
    {
        /// <summary>
        /// Retrieves the unity object being used in the scene.
        /// </summary>
        /// <returns>The unity object being used in the scene..</returns>
        object GetObject();

        /// <summary>
        /// Retrieves the object's position within the 3d scene.
        /// </summary>
        /// <value>The object's position within the 3d scene.</value>
        IScenePosition ScenePosition { get; }

        /// <summary>
        /// Retrieves the collision map width of the object.
        /// </summary>
        /// <value>The collision map width of the object.</value>
        int Width { get; }

        /// <summary>
        /// Retrieves the collision map height of the object.
        /// </summary>
        /// <value>The collision map height of the object.</value>
        int Height { get; }
    }
}
