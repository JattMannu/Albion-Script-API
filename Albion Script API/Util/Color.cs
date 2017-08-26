using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Util
{
    /// <summary>
	/// Represents an RGBA color where the valid values are 0-1
	/// </summary>
	public class Color
    {
        /// <summary>
        /// Represents a color that is black. TriHard
        /// </summary>
        public static Color Black = new Color(0.0f, 0.0f, 0.0f);
        public static Color Red = new Color(1.0f, 0.0f, 0.0f);
        public static Color Green = new Color(0.0f, 1.0f, 0.0f);
        public static Color Blue = new Color(0.0f, 0.0f, 1.0f);
        public static Color White = new Color(1.0f, 1.0f, 1.0f);
        public static Color Orange = new Color(1.0f, 0.5f, 0.0f);
        public static Color Purple = new Color(0.5f, 0.0f, 1.0f);
        public static Color Yellow = new Color(1.0f, 1.0f, 0.0f);
        public static Color Cyan = new Color(0.0f, 1.0f, 1.0f);
        public static Color SkyBlue = new Color(0.0f, 0.6f, 1.0f);

        private float r, g, b, a;

        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> class.
        /// </summary>
        /// <param name="r">The red value.</param>
        /// <param name="g">The green value.</param>
        /// <param name="b">The blue value.</param>
        /// <param name="a">The alpha value.</param>
        public Color(float r, float g, float b, float a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> class.
        /// </summary>
        /// <param name="r">The red value.</param>
        /// <param name="g">The green value.</param>
        /// <param name="b">The blue value.</param>
        public Color(float r, float g, float b) : this(r, g, b, 1)
        {

        }

        /// <summary>
        /// Gets the red value of this color.
        /// </summary>
        /// <value>The red value of this color.</value>
        public float R
        {
            get { return r; }
        }

        /// <summary>
        /// Gets the green value of this color.
        /// </summary>
        /// <value>The green value of this color.</value>
        public float G
        {
            get { return g; }
        }

        /// <summary>
        /// Gets the blue value of this color.
        /// </summary>
        /// <value>The blue value of this color.</value>
        public float B
        {
            get { return b; }
        }

        /// <summary>
        /// Gets the alpha value of this color.
        /// </summary>
        /// <value>The alpha value of this color.</value>
        public float Alpha
        {
            get { return a; }
        }

        /// <summary>
        /// Creates a new color that is a copy of this color, but darker.
        /// </summary>
        /// /// <returns>A new color that is a copy of this color, but darker.</returns>
        public Color Darker()
        {
            return new Color(Math.Max(0.0f, r - 0.50f), Math.Max(0.0f, g - 0.50f), Math.Max(0.0f, b - 0.50f), a);
        }

        /// <summary>
        /// Creates a new color that is a copy of this color, but lighter.
        /// </summary>
        /// /// <returns>A new color that is a copy of this color, but lighter.</returns>
        public Color Lighter()
        {
            return new Color(Math.Min(1.0f, r + 0.50f), Math.Min(1.0f, g + 0.50f), Math.Min(1.0f, b + 0.50f), a);
        }

        /// <summary>
        /// Creates a new color that is a copy of this color, but more transparent.
        /// </summary>
        /// <returns>A new color that is a copy of this color, but more transparent.</returns>
        public Color MoreTransparent()
        {
            return new Color(r, g, b, Math.Max(0.0f, a - 0.50f));
        }

        /// <summary>
        /// Creates a new color that is a copy of this color, but less transparent.
        /// </summary>
        /// <returns>A new color that is a copy of this color, but less transparent.</returns>
        public Color LessTransparent()
        {
            return new Color(r, g, b, Math.Min(1.0f, a + 0.50f));
        }
    }
}
