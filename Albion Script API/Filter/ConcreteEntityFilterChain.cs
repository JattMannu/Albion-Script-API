using System;
using System.Collections.Generic;

using Ennui.Api.Object;

namespace Ennui.Api.Filter
{
	public class ConcreteEntityFilterChain : EntityFilterChain<IEntityObject, ConcreteEntityFilterChain>
	{
		public ConcreteEntityFilterChain(IApi api, List<IEntityObject> list) : base(api, list)
		{
			
		}

        protected override ConcreteEntityFilterChain Create(List<IEntityObject> elements)
		{
			return new ConcreteEntityFilterChain(Api, elements);
		}
	}
}

