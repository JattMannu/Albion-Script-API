using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
	/// Represents a 2d area.
	/// </summary>
	public class Rectangle
    {
        /// <summary>
        /// The starting x coordinate of the rectangle.
        /// </summary>
        public int X;

        /// <summary>
        /// The starting y coordinate of the rectangle.
        /// </summary>
        public int Y;

        /// <summary>
        /// The width of the rectangle.
        /// </summary>
        public int Width;

        /// <summary>
        /// The height of the rectangle
        /// </summary>
        public int Height;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Ennui.Util.Rectangle"/> class.
        /// </summary>
        /// <param name="x">The starting x coordinate of the rectangle.</param>
        /// <param name="y">The starting y coordinate of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle</param>
        public Rectangle(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }
    }
}
