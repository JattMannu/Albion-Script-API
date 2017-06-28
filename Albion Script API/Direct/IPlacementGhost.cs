using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IPlacementGhost
    {
        void Set(object item, long id);

        float Rotation
        {
            get;
            set;
        }

        long ObjectId { get; }

        IScenePosition Position
        {
            get;
            set;
        }
    }
}
