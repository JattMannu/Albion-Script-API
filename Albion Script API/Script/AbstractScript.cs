using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ennui.Api.Method;
using Ennui.Api.Util;

namespace Ennui.Api.Script
{
    /// <summary>
	/// Provides a way for users to extend functionality of the bot.
	/// </summary>
	public abstract class AbstractScript : ApiResource
    {
        public AbstractScript(IApi api) : base(api)
        {
        }

        public AbstractScript() : base(null)
        {

        }

        /// <summary>
        /// Called when this script is ran within a script handler.
        /// </summary>
        /// <param name="se">The script engine executing this script.</param>
        /// <returns>Whether the script should run or not</returns>
        public virtual bool OnStart(IScriptEngine se)
        {
            return true;
        }

        /// <summary>
        /// Called every time the script handler running this script ticks.
        /// </summary>
        /// <param name="se">The script engine executing this script.</param>
        /// <returns>The amount of time to wait before calling this function again</returns>
        public abstract int OnLoop(IScriptEngine se);

        /// <summary>
        /// Called when this script is stopped within a script handler.
        /// </summary>
        /// <param name="se">The script engine executing this script.</param>
        public virtual void OnStop(IScriptEngine se)
        {

        }

        /// <summary>
        /// Called when the game attempts to paint the game screen.
        /// </summary>
        /// <param name="se">The script engine executing this script.</param>
        /// <param name="g">The graphic context to render on.</param>
        public virtual void OnPaint(IScriptEngine se, GraphicContext g)
        {

        }

        /// <summary>
        /// Called when the game attempts to write a packet to the game server.
        /// </summary>
        /// <param name="se">The script engine executing this script.</param>
        /// <param name="wrapper">The wrapper of the packet.</param>
        public virtual void OnPacketWrite(IScriptEngine se, PacketWrapper wrapper)
        {

        }
    }
}
