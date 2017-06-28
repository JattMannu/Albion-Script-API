using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public abstract class Vector3<T> : Vector2<T>
    {
        public abstract T Z { get; }

        public abstract Vector3<T> Translate(float x, float y, float z);

        public abstract T SimpleDistance(Vector3<T> other);

        public abstract Vector3<T> Distance(Vector3<T> other);

        public abstract IArea<T> Expand(T x, T y, T z);
    }
}
