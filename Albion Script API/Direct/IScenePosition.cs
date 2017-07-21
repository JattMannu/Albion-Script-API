using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    /// <summary>
    /// Represents a 2-dimensional position within the 3d scene.
    /// </summary>
    public interface IScenePosition
    {
        /// <summary>
        /// The x axis offset into the scene.
        /// </summary>
        float OffsetX { get; }
        
        /// <summary>
        /// The y axis offset into the scene.
        /// </summary>
        float OffsetY { get; }
    }
}
