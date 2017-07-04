using Ennui.Api.Direct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    public interface ICodecs : IApiModule
    {
        /// <summary>
        /// Grabs a lists of codecs built for each type containing a CodecMarker attribute.
        /// </summary>
        /// <value>Lists of codecs built for each type containing a CodecMarker attribute.</value>
        Dictionary<Type, List<IFieldCodec>> List { get; }
    }
}
