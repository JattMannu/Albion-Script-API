using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Gui
{
    /// <summary>
    /// Fired when the state of a check box is changed.
    /// </summary>
    public delegate void SelectionListener(ICheckBox b);

    public interface ICheckBox : IComponent
    {
        bool IsSelected();
        void SetSelected(bool b);
        string GetText();
        void SetText(string text);
        void SetTextColor(float r, float g, float b, float a);
        void AddSelectionListener(SelectionListener listener);
    }
}
