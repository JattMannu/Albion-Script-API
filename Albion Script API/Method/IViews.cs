using Ennui.Api.Direct.Object;
using Ennui.Api.Direct.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for interfacing with game object views.
	/// </summary>
    public interface IViews : IApiModule
    {
        /// <summary>
		/// Gets the view for the local player.
		/// </summary>
		/// <value>The view of the local player.</value>
		ILocalPlayerCharacterView LocalView { get; }

        /// <summary>
        /// Retrieves the view attached to the provided object
        /// </summary>
        /// <returns>The view attached to the provided object.</returns>
        /// <param name="obj">Object.</param>
        ISimulationObjectView ViewFor(ISimulationObject obj);
    }
}
