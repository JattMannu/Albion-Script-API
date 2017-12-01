namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for interfacing with the pay silver window in game.
	/// </summary>
	public interface IPaySilverWindow : IApiModule, IWidget
    {
        /// <summary>
        /// Attempts to click the pay button.
        /// </summary>
        bool Pay();
    }
}
