using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public interface IApiResource
    {
        IApi Api { get; set; }
    }
}
