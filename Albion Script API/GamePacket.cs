namespace Ennui.Api
{
    /// <summary>
    /// Represents a packet being used by the game.
    /// </summary>
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
