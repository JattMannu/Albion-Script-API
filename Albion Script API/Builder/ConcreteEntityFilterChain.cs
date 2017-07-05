using System;
using System.Collections.Generic;

using Ennui.Api.Direct.Object;

namespace Ennui.Api.Builder
{
	public class ConcreteEntityFilterChain : EntityFilterChain<IEntityObject, ConcreteEntityFilterChain>
	{
		public ConcreteEntityFilterChain(IApi api, List<IEntityObject> list) : base(api, list)
		{
			
		}
		
		public override ConcreteEntityFilterChain Create(List<IEntityObject> elements)
		{
			return new ConcreteEntityFilterChain(Api, elements);
		}
	}
}

