﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public abstract class Vector2<T>
    {
        public abstract T X { get; }
        public abstract T Y { get; }

        public abstract Vector2<T> Translate(T x, T y);

        public abstract T SimpleDistance(Vector2<T> other);

        public abstract Vector2<T> Distance(Vector2<T> other);

        /// <inheritdoc/>
		public override string ToString()
        {
            return "[Vector2 - " + X + ", " + Y + "]";
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
        public bool Equals(Vector2<T> b)
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

            return this.X.Equals(b.X) && this.Y.Equals(b.Y);
        }

        /// <inheritdoc/>
        public static bool operator ==(Vector2<T> a, Vector2<T> b)
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

            return a.X.Equals(b.X) && a.Y.Equals(b.Y);
        }

        /// <inheritdoc/>
        public static bool operator !=(Vector2<T> a, Vector2<T> b)
        {
            return !(a == b);
        }
    }
}
