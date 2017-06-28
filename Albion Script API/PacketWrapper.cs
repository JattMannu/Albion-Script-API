using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public struct PacketWrapper
    {
        public short Opcode;
        public SerializationWrapper Serializer;
    }
}
