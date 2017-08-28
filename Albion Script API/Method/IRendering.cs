using Ennui.Api.Util;

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

        /// <summary>
        /// Draws a line from the start vector, to the end vector.
        /// </summary>
        /// <param name="color">The color to draw the line in,</param>
        /// <param name="start">The start of the line.</param>
        /// <param name="end">The end of the line.</param>
        void DrawLine(Color color, Vector2<float> start, Vector2<float> end);

        /// <summary>
        /// Fills a square area from start to end.
        /// </summary>
        /// <param name="color">The color to draw the area in,</param>
        /// <param name="start">The start of the area.</param>
        /// <param name="end">The end of the area.</param>
        void FillSquare(Color color, Vector2<float> start, Vector2<float> end);

        /// <summary>
        /// Draws a filled polygon.
        /// </summary>
        /// <param name="color">The color to draw the polygon with.</param>
        /// <param name="one">The first point.</param>
        /// <param name="two">The second point.</param>
        /// <param name="three">The third point.</param>
        /// <param name="four">The fourth point.</param>
        void FillPolygon(Color color, Vector2<float> one, Vector2<float> two, Vector2<float> three, Vector2<float> four);
    }
}
