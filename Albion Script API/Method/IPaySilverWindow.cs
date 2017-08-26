namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for interfacing with the pay silver window in game.
	/// </summary>
	public interface IPaySilverWindow : IApiModule
    {
        /// <summary>
        /// Checks if the pay server gui is currently open
        /// </summary>
        /// <value><c>true</c> if the pay silver gui is currently open; otherwise, <c>false</c>.</value>
        bool IsOpen { get; }

        /// <summary>
        /// Attempts to click the pay button.
        /// </summary>
        bool Pay();
    }
}
