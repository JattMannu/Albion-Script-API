using Ennui.Api.Gui;
using Ennui.Api.Util;

namespace Ennui.Api.Method
{
    /// <summary>
    /// Provides instances of complex interfaces used internally by the game (i.e. instances end-users can't safely create.)
    /// </summary>
    public interface IFactories : IApiModule
    {
        /// <summary>
        /// Creates a scene position with the provided coordinates.
        /// </summary>
        /// <param name="x">The x coordinate to create the position at.</param>
        /// <param name="y">The y coordinate to create the position at.</param>
        /// <returns>The newly creates position.</returns>
        IScenePosition CreateScenePosition(float x, float y);

        /// <summary>
        /// Creates a new set of mesh data with default values.
        /// </summary>
        /// <returns>The newly created mesh data.</returns>
        IMeshData CreateMeshData();

        /// <summary>
        /// Creates a new mesh with default values.
        /// </summary>
        /// <returns>The newly created mesh.</returns>
        IMesh CreateMesh();

        /// <summary>
        /// Creates a font.
        /// </summary>
        /// <param name="name">The name of the font family to use.</param>
        /// <param name="size">The size of the font to create.</param>
        /// <param name="flags">The flags to use for creating the font.</param>
        /// <returns>The created font.</returns>
        Font CreateFont(string name, int size, int flags = 0);

        /// <summary>
        /// Creates an image.
        /// </summary>
        /// <param name="base64">The image encoded as a base64 string.</param>
        /// <returns>The newly created image</returns>
        Image ImageFromBase64(string base64);

        /// <summary>
        /// Creates a new input field.
        /// </summary>
        /// <returns>The new input field.</returns>
        IInputField CreateGuiInputField();

        /// <summary>
        /// Creates a new panel.
        /// </summary>
        /// <returns>The new panel.</returns>
        IPanel CreateGuiPanel();

        /// <summary>
        /// Creates a new checkbox.
        /// </summary>
        /// <returns>The new checkbox.</returns>
        ICheckBox CreateGuiCheckBox();

        /// <summary>
        /// Creates a new label.
        /// </summary>
        /// <returns>The new label.</returns>
        ILabel CreateGuiLabel();

        /// <summary>
        /// Creates a new button.
        /// </summary>
        /// <returns>The new button.</returns>
        IButton CreateGuiButton();
    }
}
