﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct
{
    public interface IItemContainer
    {
       List<IItemStack> ItemList { get; }
    }
}