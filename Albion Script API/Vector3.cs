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

        /// <inheritdoc/>
		public override string ToString()
        {
            return "[Vector3 - " + X + ", " + Y + "]";
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var p = (Vector2<T>)obj;
            return (X.Equals(p.X)) && (Y.Equals(p.Y));
        }

        /// <inheritdoc/>
        public bool Equals(Vector3<T> b)
        {
            if (ReferenceEquals(this, b))
            {
                return true;
            }

            if (ReferenceEquals(this, null))
            {
                return false;
            }
            if (ReferenceEquals(b, null))
            {
                return false;
            }

            if (System.Object.ReferenceEquals(this, b))
                return true;

            return X.Equals(b.X) && Y.Equals(b.Y) && Z.Equals(b.Z);
        }

        /// <inheritdoc/>
        public static bool operator ==(Vector3<T> a, Vector3<T> b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (ReferenceEquals(a, null))
            {
                return false;
            }
            if (ReferenceEquals(b, null))
            {
                return false;
            }

            if (System.Object.ReferenceEquals(a, b))
                return true;

            return a.X.Equals(b.X) && a.Y.Equals(b.Y) && a.Z.Equals(b.Z);
        }

        /// <inheritdoc/>
        public static bool operator !=(Vector3<T> a, Vector3<T> b)
        {
            return !(a == b);
        }
    }
}
