using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public interface IPlaceItemEventHandler
    {
        bool Place(long id, IScenePosition pos, float rotation);
    }
}
