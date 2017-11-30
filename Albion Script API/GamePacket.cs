namespace Ennui.Api
{
    public struct GamePacket
    {
        /// <summary>
        /// The opcode of the packet.
        /// </summary>
        public short Opcode;

        /// <summary>
        /// The codec for modifying the fields of this packet.
        /// </summary>
        public LiveGamePacketCodec Codec;
    }
}
