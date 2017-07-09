using Ennui.Api.Direct;
using Ennui.Api.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    public interface IFactories : IApiModule
    {
        IScenePosition CreateScenePosition(float x, float y);

        Font CreateFont(string name, int size, int flags = 0);

        IInputField CreateGuiInputField();
        IPanel CreateGuiPanel();
        ICheckBox CreateGuiCheckBox();
        ILabel CreateGuiLabel();
        IButton CreateGuiButton();
    }
}
