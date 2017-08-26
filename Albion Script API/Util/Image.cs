namespace Ennui.Api.Util
{
    /// <summary>
	/// Represents a 2d image.
	/// </summary>
	public interface Image
    {
        /// <summary>
        /// Gets the width of this image.
        /// </summary>
        /// <returns>The width of this image.</returns>
        int GetWidth();

        /// <summary>
        /// Gets the height of this image.
        /// </summary>
        /// <returns>The height of this image.</returns>
        int GetHeight();

        /// <summary>
        /// Sets the color at the provided pixel coordinates.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <param name="c">The color to set.</param>
        void SetPixel(int x, int y, Color c);

        /// <summary>
        /// Gets the color at the provided pixel coordinates.
        /// </summary>
        /// <returns>The color of the pixel at the provided coordinates.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        Color GetPixel(int x, int y);
    }
}
