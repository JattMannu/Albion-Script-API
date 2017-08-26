namespace Ennui.Api.Gui
{
    public interface IInputField : IComponent
    {
        /// <summary>
        /// Retrieves the entered text of this input field.
        /// </summary>
        /// <returns>This input field's entered text.</returns>
        string GetText();

        /// <summary>
        /// Changes the entered text of this input field.
        /// </summary>
        /// <param name="text">The new text.</param>
        void SetText(string text);

        /// <summary>
        /// Changes the text color of this input field.
        /// </summary>
        /// <param name="r">The new red value.</param>
        /// <param name="g">The new green value.</param>
        /// <param name="b">The new blue value.</param>
        /// <param name="a">The new alpha value.</param>
        void SetColor(float r, float g, float b, float a);
    }
}
