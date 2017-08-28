namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of static utilities for interfacing with the login window in game.
	/// </summary>
    public interface ILoginWindow : IApiModule
    {
        /// <summary>
        /// Checks if the login window is currently open
        /// </summary>
        /// <value><c>true</c> if the login window is currently open; otherwise, <c>false</c>.</value>
        bool IsOpen { get; }

        /// <summary>
        /// Sets the email in the email input form on the login window.
        /// </summary>
        /// <returns><c>true</c>, if email was set, <c>false</c> otherwise.</returns>
        /// <param name="email">Email.</param>
        bool SetEmail(string email);

        /// <summary>
        /// Sets the password in the password input form on the login window.
        /// </summary>
        /// <returns><c>true</c>, if password was set, <c>false</c> otherwise.</returns>
        /// <param name="pass">Email.</param>
        bool SetPassword(string pass);

        /// <summary>
        /// Clicks the login button on the login window.
        /// </summary>
        bool ClickLogin();

        /// <summary>
        /// Attempts to login with the specified credentials.
        /// </summary>
        /// <param name="email">The email to login with.</param>
        /// <param name="pass">The password to login with.</param>
        bool Login(string email = "", string pass = "");
    }
}
