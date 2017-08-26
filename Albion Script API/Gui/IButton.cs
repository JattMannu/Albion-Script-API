namespace Ennui.Api.Gui
{
    /// <summary>
    /// Fired when the button that it's registered to is clicked.
    /// </summary>
    public delegate void ButtonActionListener(IButton b);

    public interface IButton : IComponent
    {
        void AddActionListener(ButtonActionListener listener);
        void SetText(string text);
        void SetTextColor(float r, float g, float b, float a);
    }
}
