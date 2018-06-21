using Ennui.Api.Util;

namespace Ennui.Api.Method
{
    public enum MouseButton
    {
        Left = 0,
        Right = 1,
        Middle = 2,
    }

    public interface IInput : IApiModule
    {
        /// <summary>
        /// The location of the mouse on the terrain.
        /// </summary>
        Vector3<float> MouseTerrainLocation { get; }

        /// <summary>
        /// The location of the mouse on the game screen.
        /// </summary>
        Vector2<float> MousePosition { get; }

        /// <summary>
        /// Whether or not input is enabled.
        /// </summary>
        bool Enabled { set; }

        /// <summary>
        /// Determines if a key is currently pressed down.
        /// </summary>
        /// <param name="button">The mouse button to check</param>
        /// <returns>If the provided mouse button is pressed.</returns>
        bool IsMouseButtonPressed(MouseButton button);

        /// <summary>
        /// Determines if a key is currently pressed down.
        /// </summary>
        /// <param name="key">The name of the key to check.</param>
        /// <returns>If the key with the provided name is pressed.</returns>
        bool IsKeyPressed(string key);
    }
}
