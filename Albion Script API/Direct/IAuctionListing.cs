namespace Ennui.Api.Direct
{
    public interface IAuctionListing
    {
        int UniqueName { get; }

        int Tier { get; }

        int QualityLevel { get; }
    }
}
