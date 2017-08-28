using Ennui.Api.Object;
using Ennui.Api.View;

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
        /// <return>The local player's character view.</return>
		/// <value>The view of the local player.</value>
		ILocalPlayerCharacterView LocalView { get; }

        /// <summary>
        /// Retrieves the view attached to the provided object
        /// </summary>
        /// <returns>The view attached to the provided object.</returns>
        /// <param name="obj">The simulation object to resolve the view for.</param>
        ISimulationObjectView ViewFor(ISimulationObject obj);
    }
}
