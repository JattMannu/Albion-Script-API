using Ennui.Api.Meta;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of utilities for interfacing with the expedition hud window in game.
	/// </summary>
    public interface IExpeditionHud : IApiModule, IWidget
    {
        /// <summary>
        /// The current state of the hud.
        /// </summary>
        ExpeditionHudState State { get; }

        /// <summary>
        /// If the progress popup is open.
        /// </summary>
        bool IsProgressPopupOpen { get; }

        /// <summary>
        /// The additional info progress text.
        /// </summary>
        string ProgressAdditionalInfo { get; }

        /// <summary>
        /// The progress label text.
        /// </summary>
        string ProgressLabel { get; }

        /// <summary>
        /// If the reward popup is open.
        /// </summary>
        bool IsRewardPopupOpen { get; }

        /// <summary>
        /// The first line of reward text.
        /// </summary>
        string RewardText1 { get; }

        /// <summary>
        /// The second line of reward text.
        /// </summary>
        string RewardText2 { get; }
    }
}
