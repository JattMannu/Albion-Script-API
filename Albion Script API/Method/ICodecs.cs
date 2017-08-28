using System;
using System.Collections.Generic;

namespace Ennui.Api.Method
{
    public interface ICodecs : IApiModule
    {
        /// <summary>
        /// Grabs a lists of codecs built for each type containing a CodecMarker attribute.
        /// </summary>
        /// <value>Lists of codecs built for each type containing a CodecMarker attribute.</value>
        Dictionary<Type, List<IFieldCodec>> List { get; }

        /// <summary>
        /// Serializes an object to a json string.
        /// </summary>
        /// <param name="o">The object to serialize.</param>
        /// <returns>The object serialized as a json string.</returns>
        string ToJson(object o);

        /// <summary>
        /// Deserializes a json string to an object.
        /// </summary>
        /// <typeparam name="T">The type of object to create.</typeparam>
        /// <param name="json">The json string to deserialize.</param>
        /// <returns>The deserialized object.</returns>
        T FromJson<T>(string json);
    }
}
