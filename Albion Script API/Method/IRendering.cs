using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
    /// Provides a set of static utility methods for dealing with the game's rendering.
    /// </summary>
    public interface IRendering : IApiModule
    {
        /// <summary>
        /// Disables the rendering of everything in the game.
        /// </summary>
        void DisableRendering();

        /// <summary>
        /// Enables the rendering of everything in the game.
        /// </summary>
        void EnableRendering();

        /// <summary>
        /// Changes the main camera's field of view.
        /// </summary>
        /// <param name="fov">The new field of view.</param>
        void SetFov(float fov);

        /// <summary>
        /// Effectively changes the zoom amount of the camera.
        /// </summary>
        /// <param name="zoom">The new zoom value.</param>
        void SetZoom(float zoom);


        /// <summary>
        /// Disables the fog applied to the game's camera.
        /// </summary>
        bool DisableFog();
    }
}
