namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of utilities for interfacing with the character info window in game.
	/// </summary>
    public interface ICharacterInfoWindow : IApiModule, IWidget
    {
        /// <summary>
        /// Forces this window open.
        /// </summary>
        void Open();
    }
}
