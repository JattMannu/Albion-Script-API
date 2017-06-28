using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public abstract class ApiModule : IApiModule
    {
        public IApi Api { get; set; }
    }
}
