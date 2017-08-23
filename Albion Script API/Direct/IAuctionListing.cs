using System;

namespace Ennui.Api.Direct
{
    public interface IAuctionListing
    {
         int Amount { get; }

         string AuctionType { get; }

         string BuyerCharacterId { get; }

         string BuyerName { get; }

         int EnchantmentLevel { get; }

         DateTime Expires { get; }

         bool HasBuyerFetched { get; }

         bool HasSellerFetched { get; }

         long Id { get; }

         bool IsFinished { get; }

         string ItemGroupTypeId { get; }

         string ItemTypeId { get; }

         int QualityLevel { get; }

         string SellerCharacterId { get; }

         string SellerName { get; }

         int Tier { get; }

         ulong TotalPriceSilver { get; }

         ulong UnitPriceSilver { get; }
    }
}
