using Ennui.Api.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
    /// Provides a set of static utilities for interacting with the in game chat.
    /// </summary>
    public interface IChat : IApiModule
    {
        /// <summary>
        /// Sends a chat message.
        /// </summary>
        /// <returns><c>true</c>, if the message was sent, <c>false</c> otherwise.</returns>
        /// <param name="channel">The channel to send the message to.</param>
        /// <param name="message">The message to send.</param>
        bool SendMessage(Channel channel, string message);
    }
}
