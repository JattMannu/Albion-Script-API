using System.Collections.Generic;

namespace Ennui.Api.Method
{
    public interface ISerialization : IApiModule
    {
        /// <summary>
        /// Converts an object into a dictionary containing serialized values.
        /// </summary>
        /// <returns>The dictionary containing serialized values.</returns>
        /// <param name="o">The object to serialize.</param>
        Dictionary<byte, object> TearDown(object o);

        /// <summary>
        /// Deserializes a dictionary of values into an object.
        /// </summary>
        /// <param name="to">The object to store the values in.</param>
        /// <param name="vals">The values to store.</param>
        void BuildUp(object to, Dictionary<byte, object> vals);
    }
}
