using Ennui.Api.Direct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    public interface IFactories : IApiModule
    {
        IScenePosition CreateScenePosition(float x, float y);
    }
}
