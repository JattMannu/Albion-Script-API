using System;

using Ennui.Api.Meta;

namespace Ennui.Api.Filter
{
	public struct TypeSet
	{
		public int MinTier { get; set; }
		public int MaxTier { get; set; }
		public int MinRarity { get; set; }
		public int MaxRarity { get; set; }
		public ResourceType Type { get; set; }

		public TypeSet(int minTier, int maxTier, ResourceType type, int minRarity = 0, int maxRarity = int.MaxValue)
		{
			this.MinTier = minTier;
			this.MaxTier = maxTier;
			this.Type = type;
			this.MinRarity = minRarity;
			this.MaxRarity = maxRarity;
		}
	}
}

