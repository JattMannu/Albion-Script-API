using Ennui.Api.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public class SerializationWrapper
    {
        public object Object;
        private Dictionary<byte, object> @params;
        private ISerialization serialization;

        public SerializationWrapper(object obj, ISerialization serialization)
        {
            this.Object = obj;
            this.serialization = serialization;
            this.@params = serialization.TearDown(obj);
        }

        public object getParameterRaw(byte index)
        {
            return @params[index];
        }

        public T GetParameter<T>(byte index)
        {
            return (T)@params[index];
        }

        public Dictionary<byte, object> Parameters
        {
            get { return @params; }
        }

        public void PutParameter(byte index, object val)
        {
            @params[index] = val;
            serialization.BuildUp(Object, @params);
        }
    }
}
