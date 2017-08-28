using System;

namespace Ennui.Api.Method
{
    /// <summary>
    /// Represents a response from a get request.
    /// </summary>
    public class GetResponse
    {
        /// <summary>
        /// The status code of the response.
        /// </summary>
        public int ResponseCode;

        /// <summary>
        /// The body of the response.
        /// </summary>
        public string ResponseBody;
    }

    /// <summary>
	/// Provides a set of static utilities for networking.
	/// </summary>
    public interface INet : IApiModule
    {
        /// <summary>
        /// Makes a get request at the provided url.
        /// </summary>
        /// <param name="url">The url to make the request at.</param>
        /// <param name="contentType">Content type.</param>
        GetResponse Get(string url);

        /// <summary>
        /// Sends a packet to the server.
        /// </summary>
        /// <param name="wrapper">The internal packet object as used by the game.</param>
        void SendPacket(SerializationWrapper wrapper);

        /// <summary>
        /// Finds the packet type for the outgoing packet with the provided opcode.
        /// </summary>
        /// <returns>The packet type for the outgoing packet with the provided opcode.</returns>
        /// <param name="opcode">The opcode of the packet type to search for.</param>
        Type FindOutgoingPacketType(byte opcode);

        /// <summary>
        /// Creates an instance of an internal game packet.
        /// </summary>
        /// <returns>The packet instance.</returns>
        /// <param name="opcode">The opcode of the packet to create.</param>
        SerializationWrapper OutgoingPacketInstance(byte opcode);
    }
}
