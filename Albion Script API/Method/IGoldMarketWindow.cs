namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of utilities for interfacing with the gold market window in game.
	/// </summary>
    public interface IGoldMarketWindow : IApiModule, IWidget
    {
        /// <summary>
        /// Forces this window open.
        /// </summary>
        void Open();

        /// <summary>
        /// The amount entered for buying gold.
        /// </summary>
        int BuyAmount { get; set; }

        /// <summary>
        /// The amount entered for selling gold.
        /// </summary>
        int SellAmount { get; set; }

        /// <summary>
        /// Buys the amount of entered gold.
        /// </summary>
        bool BuyGold();

        /// <summary>
        /// Sells the amount of entered gold.
        /// </summary>
        bool SellGold();
    }
}
