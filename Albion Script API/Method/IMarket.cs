using System.Collections;
using System.Collections.Generic;

using Ennui.Api.Meta;

namespace Ennui.Api.Method
{
    public delegate void PriceRequestFinished(IList item);

    public interface IMarket
    {
        bool IsOpen { get; }

        List<string> Categories { get; }

        List<string> SubCategories { get; }
        
        HashSet<short> BuildItemTypes(string search);

        string SelectedTier { get; }

        string SelectedQuality { get; }

        string SelectedEnchantmentLevel { get; }

        string SelectedCategory { get; }

        string SelectedSubCategory { get; }

        string SearchInput { get; set; }

        int IndexOfTier(string tier);

        int IndexOfQuality(string quality);

        int IndexOfEnchantmentLevel(string enchantmentLevel);

        int IndexOfCategory(string category);

        int IndexOfSubCategory(string subCategory);

        int TierIndex { get; set; }

        int QualityIndex { get; set; }

        int EnchantmentLevelIndex { get; set; }

        int CategoryIndex { get; set; }

        int SubCategoryIndex { get; set; }

        void RequestItems(string category, string subCategory, string enchantmentLevel, FilterType enchantmentFilterType, string quality, FilterType qualityFilterType, string tier, short[] itemTypes, bool ascending, PriceRequestFinished finished);
    }
}
