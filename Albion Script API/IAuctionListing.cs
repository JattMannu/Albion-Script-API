using System;

namespace Ennui.Api
{
    /// <summary>
    /// Represents a listing within the marketplace.
    /// </summary>
    public interface IAuctionListing
    {
        /// <summary>
        /// The amount of items being bought/sold
        /// </summary>
        int Amount { get; }

        /// <summary>
        /// The type of auction (offer/request)
        /// </summary>
        string AuctionType { get; }

        /// <summary>
        /// The id of the character that's buying.
        /// </summary>
        string BuyerCharacterId { get; }

        /// <summary>
        /// The name of the buyer.
        /// </summary>
        string BuyerName { get; }

        /// <summary>
        /// The enchantment level of the item.
        /// </summary>
        int EnchantmentLevel { get; }

        /// <summary>
        /// The date that this auction expires on.
        /// </summary>
        DateTime Expires { get; }

        /// <summary>
        /// If this auction's buyer has fetched the items.
        /// </summary>
        bool HasBuyerFetched { get; }

        /// <summary>
        /// If this auction's seller has fetched the items.
        /// </summary>
        bool HasSellerFetched { get; }

        /// <summary>
        /// The (presumeably) unique id of this auction.
        /// </summary>
        long Id { get; }

        /// <summary>
        /// If this auction is finished.
        /// </summary>
        bool IsFinished { get; }

        /// <summary>
        /// The group id of the item.
        /// </summary>
        string ItemGroupTypeId { get; }

        /// <summary>
        /// The type id of the item.
        /// </summary>
        string ItemTypeId { get; }

        /// <summary>
        /// The quality level of the item.
        /// </summary>
        int QualityLevel { get; }

        /// <summary>
        /// The id of the character that's selling.
        /// </summary>
        string SellerCharacterId { get; }

        /// <summary>
        /// The name of the seller.
        /// </summary>
        string SellerName { get; }

        /// <summary>
        /// The tier of the item.
        /// </summary>
        int Tier { get; }

        /// <summary>
        /// The price for all of the items.
        /// </summary>
        long TotalPriceSilver { get; }

        /// <summary>
        /// The price for each individual item.
        /// </summary>
        long UnitPriceSilver { get; }
    }
}
