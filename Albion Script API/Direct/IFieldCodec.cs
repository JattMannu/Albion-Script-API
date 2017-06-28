using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IFieldCodec
    {
        object Serialize(object to);

        void Deserialize(object to, object val);
    }
}
