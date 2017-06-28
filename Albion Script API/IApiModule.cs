using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public interface IApiModule
    {
        IApi Api { get; set; }
    }
}
