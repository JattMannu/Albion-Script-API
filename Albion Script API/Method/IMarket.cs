using System.Collections.Generic;

using Ennui.Api.Meta;

namespace Ennui.Api.Method
{
    /// <summary>
    /// Callback for requestion auction listings.
    /// </summary>
    /// <param name="auctions">The auction listings received from the server.</param>
    public delegate void PriceRequestFinished(List<IAuctionListing> auctions);

    /// <summary>
    /// Provides an interface for accessing the market (i.e. auction house.)
    /// </summary>
    public interface IMarket : IWidget
    {
        /// <summary>
        /// A list of possible category selections.
        /// </summary>
        List<string> Categories { get; }

        /// <summary>
        /// A list of possible sub-category selections.
        /// </summary>
        List<string> SubCategories { get; }
        
        /// <summary>
        /// Performs an item search using the provided input.
        /// </summary>
        /// <param name="search">The search input.</param>
        /// <returns>A set of all item ids that match the provided search input.</returns>
        HashSet<short> PerformItemSearch(string search);

        /// <summary>
        /// The selected tier.
        /// </summary>
        string SelectedTier { get; }

        /// <summary>
        /// The selected quality.
        /// </summary>
        string SelectedQuality { get; }

        /// <summary>
        /// The selected enchantment level.
        /// </summary>
        string SelectedEnchantmentLevel { get; }

        /// <summary>
        /// The selected category.
        /// </summary>
        string SelectedCategory { get; }

        /// <summary>
        /// The selected sub-category.
        /// </summary>
        string SelectedSubCategory { get; }

        /// <summary>
        /// The current search input.
        /// </summary>
        string SearchInput { get; set; }

        /// <summary>
        /// Finds the index of the tier with the provided name.
        /// </summary>
        /// <param name="tier">The name of the tier to find the index of.</param>
        /// <returns>The index of the tier with the provided name.</returns>
        int IndexOfTier(string tier);

        /// <summary>
        /// Finds the index of the quality with the provided name.
        /// </summary>
        /// <param name="quality">The name of the quality to find the index of.</param>
        /// <returns>The index of the quality with the provided name.</returns>
        int IndexOfQuality(string quality);

        /// <summary>
        /// Finds the index of the enchantment level with the provided name.
        /// </summary>
        /// <param name="enchantmentLevel">The name of the enchantment level to find the index of.</param>
        /// <returns>The index of the enchantment level with the provided name.</returns>
        int IndexOfEnchantmentLevel(string enchantmentLevel);

        /// <summary>
        /// Finds the index of the category with the provided name.
        /// </summary>
        /// <param name="tier">The name of the category to find the index of.</param>
        /// <returns>The index of the tier category the provided name.</returns>
        int IndexOfCategory(string category);

        /// <summary>
        /// Finds the index of the sub-category with the provided name.
        /// </summary>
        /// <param name="tier">The name of the sub-category to find the index of.</param>
        /// <returns>The index of the sub-category with the provided name.</returns>
        int IndexOfSubCategory(string subCategory);

        /// <summary>
        /// The selected tier index.
        /// </summary>
        int TierIndex { get; set; }

        /// <summary>
        /// The selected quality index.
        /// </summary>
        int QualityIndex { get; set; }

        /// <summary>
        /// The selected enchantment level index.
        /// </summary>
        int EnchantmentLevelIndex { get; set; }

        /// <summary>
        /// The selected category index.
        /// </summary>
        int CategoryIndex { get; set; }

        /// <summary>
        /// The selected sub category index.
        /// </summary>
        int SubCategoryIndex { get; set; }

        /// <summary>
        /// Queries a list of request auction listings from the game server.
        /// </summary>
        /// <param name="category">The category to search for.</param>
        /// <param name="subCategory">The sub-category to search for.</param>
        /// <param name="enchantmentLevel">The enchantment level to search for.</param>
        /// <param name="enchantmentFilterType">The enchantment filter type to apply.</param>
        /// <param name="quality">The quality level to search for.</param>
        /// <param name="qualityFilterType">The quality filter type to apply.</param>
        /// <param name="tier">The tier to search for.</param>
        /// <param name="itemIds">The item ids to search for.</param>
        /// <param name="ascending">If the query should include ascending items.</param>
        /// <param name="finished">The callback that all auction listings will be sent to.</param>
        void DemandRequests(string category, string subCategory, string enchantmentLevel, FilterType enchantmentFilterType, string quality, FilterType qualityFilterType, string tier, short[] itemIds, bool ascending, PriceRequestFinished finished);

        /// <summary>
        /// Queries a list of offer auction listings from the game server.
        /// </summary>
        /// <param name="category">The category to search for.</param>
        /// <param name="subCategory">The sub-category to search for.</param>
        /// <param name="enchantmentLevel">The enchantment level to search for.</param>
        /// <param name="enchantmentFilterType">The enchantment filter type to apply.</param>
        /// <param name="quality">The quality level to search for.</param>
        /// <param name="qualityFilterType">The quality filter type to apply.</param>
        /// <param name="tier">The tier to search for.</param>
        /// <param name="itemIds">The item ids to search for.</param>
        /// <param name="ascending">If the query should include ascending items.</param>
        /// <param name="finished">The callback that all auction listings will be sent to.</param>
        void DemandOffers(string category, string subCategory, string enchantmentLevel, FilterType enchantmentFilterType, string quality, FilterType qualityFilterType, string tier, short[] itemIds, bool ascending, PriceRequestFinished finished);

        /// <summary>
        /// Opens a tab within the market widget.
        /// </summary>
        /// <param name="category">The category of the tab to open.</param>
        /// <returns>If the tab was opened successfully.</returns>
        bool OpenCategory(AuctionHouseCategory category);

        /// <summary>
        /// Attempts to buy an amount of items from an offer.
        /// </summary>
        /// <param name="id">The id of the offer to buy.</param>
        /// <param name="amount">The amount to buy.</param>
        /// <returns>If the item was bought successfully.</returns>
        bool BuyOffer(long id, int amount);
    }
}
