using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
	/// Provides a set of utilities for interfacing with the gold market window in game.
	/// </summary>
    public interface IGoldMarketWindow : IApiModule
    {
        /// <summary>
        /// <c>true</c> if the gold market window is currently open; otherwise, <c>false</c>.
        /// </summary>
        bool IsOpen { get; }

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
        void BuyGold();

        /// <summary>
        /// Sells the amount of entered gold.
        /// </summary>
        void SellGold();
    }
}
