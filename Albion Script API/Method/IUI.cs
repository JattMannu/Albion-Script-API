namespace Ennui.Api.Method
{
    public interface IUI : IApiModule
    {
        /// <summary>
        /// Shows a message on the user's game screen in a popup window.
        /// </summary>
        /// <param name="msg">The message to show</param>
        void ShowMessageOk(string msg);

        /// <summary>
        /// Whether or not UI input is enabled.
        /// </summary>
        bool InputEnabled { set; }
    }
}
