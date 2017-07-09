using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Gui
{
    public interface IComboBox : IComponent
    {
        void AddSelection(string selection);
        string Selected { get; }
    }
}
