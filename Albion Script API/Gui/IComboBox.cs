namespace Ennui.Api.Gui
{
    public interface IComboBox : IComponent
    {
        void AddSelection(string selection);
        string Selected { get; }
    }
}
