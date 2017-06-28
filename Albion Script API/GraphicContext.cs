using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
	/// Provides a interface for rendering to something.
	/// </summary>
	public abstract class GraphicContext
    {
        /// <summary>
        /// Changes the color that is being rendered with.
        /// </summary>
        /// <param name="col">The new color to render with.</param>
        public abstract void SetColor(Color col);

        /// <summary>
        /// Changes the font that is being used to render strings.
        /// </summary>
        /// <param name="font">The new font to use to render strings.</param>
        public abstract void SetFont(Font font);

        /// <summary>
        /// Draws text at specified coordinates.
        /// </summary>
        /// <param name="s">The text to draw.</param>
        /// <param name="x">The x coordinate to draw at.</param>
        /// <param name="y">The y coordinate to draw at.</param>
        public abstract void DrawString(string s, int x, int y);

        /// <summary>
        /// Draws shadowed text at specified coordinates.
        /// </summary>
        /// <param name="s">The text to draw.</param>
        /// <param name="x">The x coordinate to draw at.</param>
        /// <param name="y">The y coordinate to draw at.</param>
        /// <param name="shadowColor">The color to use for the shadow.</param>
        public abstract void DrawShadowString(string s, int x, int y, Color shadowColor);

        /// <summary>
        /// Draws shadowed text at specified coordinates.
        /// </summary>
        /// <param name="s">The text to draw.</param>
        /// <param name="x">The x coordinate to draw at.</param>
        /// <param name="y">The y coordinate to draw at.</param>
        public void DrawShadowString(string s, int x, int y)
        {
            DrawShadowString(s, x, y, new Color(0, 0, 0, 1));
        }

        /// <summary>
        /// Draws a filled rect using the current color at the provided coordinates.
        /// </summary>
        /// <param name="x0">The start x coordinate.</param>
        /// <param name="y0">The start y coordinate.</param>
        /// <param name="x1">The end x coordinate.</param>
        /// <param name="y1">The end y coordinate.</param>
        public abstract void FillRect(int x0, int y0, int x1, int y1);

        /// <summary>
        /// Draws a line from the start point, to the end point
        /// </summary>
        /// <param name="x0">The start x coordinate.</param>
        /// <param name="y0">The start y coordinate.</param>
        /// <param name="x1">The end x coordinate.</param>
        /// <param name="y1">The end y coordinate.</param>
        public abstract void DrawLine(int x0, int y0, int x1, int y1);

        /// <summary>
        /// Draws an image.
        /// </summary>
        /// <param name="i">The image to draw.</param>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        public abstract void DrawImage(Image i, int x, int y, int width, int height);
    }
}
