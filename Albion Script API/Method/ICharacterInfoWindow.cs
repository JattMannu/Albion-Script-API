using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for interfacing with the character info in game.
	/// </summary>
    public interface ICharacterInfoWindow : IApiModule
    {
        /// <summary>
		/// Checks if the character info gui is currently open
		/// </summary>
		/// <value><c>true</c> if the character info gui is currently open; otherwise, <c>false</c>.</value>
		bool IsOpen { get; }
    }
}
