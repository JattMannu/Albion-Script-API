namespace Ennui.Api.Gui
{
    public interface ILabel : IComponent
    {
        /// <summary>
        /// Retrieves the text of this label.
        /// </summary>
        /// <returns>The text of this label.</returns>
        string GetText();

        /// <summary>
        /// Changes the text of this label.
        /// </summary>
        /// <param name="text">The new text.</param>
        void SetText(string text);

        /// <summary>
        /// Changes the text color of this label.
        /// </summary>
        /// <param name="r">The new red value.</param>
        /// <param name="g">The new green value.</param>
        /// <param name="b">The new blue value.</param>
        /// <param name="a">The new alpha value.</param>
        void SetColor(float r, float g, float b, float a);
    }
}
