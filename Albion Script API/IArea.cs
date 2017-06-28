﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public interface IArea<T>
    {
        Vector3<T> Start { get; }
        Vector3<T> End { get; }
        IArea<T> Expand(T x, T y, T z);
        bool Contains(Vector3<T> loc);
        bool ContainsIgnoreHeight(Vector3<T> loc);
    }
}