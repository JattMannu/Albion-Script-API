namespace Ennui.Api.Method
{
    /// <summary>
	/// Provies a set of utility methods for interacting with a vault object in game.
	/// </summary>
    public interface IBanking : IApiModule
    {
        /// <summary>
		/// Checks if the banking gui is currently open
		/// </summary>
		/// <value><c>true</c> if the banking gui is currently open; otherwise, <c>false</c>.</value>
        bool IsOpen { get; }

        /// <summary>
        /// Deposit the specified items into the bank.
        /// </summary>
        /// <returns><c>true</c>, if the items were deposited, <c>false</c> otherwise.</returns>
        /// <param name="items">Items.</param>
        bool Deposit(params IItemStack[] items);

        /// <summary>
        /// Attempts to deposit all items from the inventory into the bank that have a unique name
        /// containing a substring of any of the provided strings.
        /// </summary>
        /// <returns><c>true</c>, if the items were deposited, <c>false</c> otherwise.</returns>
        /// <param name="substrings">Substrings.</param>
        bool DepositItemsWithSubstring(params string[] substrings);

        /// <summary>
        /// Withdraws the specified items from the bank
        /// </summary>
        /// <returns><c>true</c>, if the items were withdrawn, <c>false</c> otherwise.</returns>
        /// <param name="items">Items.</param>
        bool Withdraw(params IItemStack[] items);

        /// <summary>
        /// Attempts to withdraw all items from the vault into the inventory that have a unique name
        /// containing a substring of any of the provided strings.
        /// </summary>
        /// <returns><c>true</c>, if the items were withdrawn, <c>false</c> otherwise.</returns>
        /// <param name="substrings">Substrings.</param>
        bool WithdrawItemsWithSubstring(params string[] substrings);

        /// <summary>
        /// Checks if the inventory has any item with one of the provided names in their name.
        /// </summary>
        /// <param name="names">The names to match items against</param>
        /// <returns>If the inventory has any items with one of the provided names in them</returns>
        bool HasItemContainingName(params string[] names);
    }
}
