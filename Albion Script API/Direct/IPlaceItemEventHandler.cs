using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IPlaceItemEventHandler
    {
        bool Place(long id, IScenePosition pos, float rotation);
    }
}
