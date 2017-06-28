using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public class ApiResource : IApiResource
    {
        public IApi Api { get; set; }
    }
}
