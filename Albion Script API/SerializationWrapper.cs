using System.Collections.Generic;

using Ennui.Api.Method;

namespace Ennui.Api
{
    /// <summary>
    /// Handles the conversion to and from the game's packet structure.
    /// 
    /// Serialization of objects is undefined (i.e. handled by the game), but only primitive IL types are transferred over raw packets. We
    /// use the game's functionality to serialize & deserialize the primitive types.
    /// </summary>
    public class LiveGamePacketCodec
    {
        public object Object;
        private Dictionary<byte, object> @params;
        private ISerialization serialization;

        public LiveGamePacketCodec(object obj, ISerialization serialization)
        {
            this.Object = obj;
            this.serialization = serialization;
            this.@params = serialization.TearDown(obj);
        }

        /// <summary>
        /// Retrieves the parameter at the provided index.
        /// </summary>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="index">The index of the parameter to retrieve.</param>
        /// <returns>The parameter at the provided index.</returns>
        public T GetParameter<T>(byte index)
        {
            return (T)@params[index];
        }

        /// <summary>
        /// Stores a parameter at the provided index.
        /// </summary>
        /// <param name="index">The index to store the parameter at.</param>
        /// <param name="val">The value to store.</param>
        public void PutParameter(byte index, object val)
        {
            @params[index] = val;
            serialization.BuildUp(Object, @params);
        }

        /// <summary>
        /// All parameters stored in the packet.
        /// </summary>
        public Dictionary<byte, object> Parameters
        {
            get { return @params; }
        }
    }
}
