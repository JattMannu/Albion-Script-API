using System;

namespace Ennui.Api.Util
{
    /// <summary>
    /// Represents a 2d coordinate.
    /// </summary>
    /// <typeparam name="T">The type of number to use internally.</typeparam>
    public abstract class Vector2<T> : IEquatable<Vector2<T>>
    {
        /// <summary>
        /// The 2d coordinate's x axis
        /// </summary>
        public abstract T X { get; set; }

        /// <summary>
        /// The 2d coordinate's y axis
        /// </summary>
        public abstract T Y { get; set; }

        /// <summary>
        /// Creates a new vector2 that's offset by the provided amount.
        /// </summary>
        /// <param name="x">The amount to offset on the x axis.</param>
        /// <param name="y">The amount to offset on the y axis.</param>
        /// <returns>The new, translated vector2.</returns>
        public abstract Vector2<T> Translate(T x, T y);

        /// <summary>
        /// Calculates the total distance from this vector2, and the provided vector2.
        /// </summary>
        /// <param name="other">The vector2 to calculate the distance from.</param>
        /// <returns>The distance from the other vector2.</returns>
        public abstract T SimpleDistance(Vector2<T> other);

        /// <summary>
        /// Calculates the actual distance from this vector2, and the provided vector2
        /// </summary>
        /// <param name="other">The vector2 to calculate the distance from.</param>
        /// <returns>The distance from the other vector2.</returns>
        public abstract Vector2<T> Distance(Vector2<T> other);

        /// <summary>
        /// Sets this vector's values to the provided ones.
        /// </summary>
        /// <param name="x">The new x value to set.</param>
        /// <param name="y">The new y value to set.</param>
        public abstract void Set(T x, T y);

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

            if (object.ReferenceEquals(this, b))
            {
                return true;
            }

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

            if (object.ReferenceEquals(a, b))
            {
                return true;
            }

            return a.X.Equals(b.X) && a.Y.Equals(b.Y);
        }

        /// <inheritdoc/>
        public static bool operator !=(Vector2<T> a, Vector2<T> b)
        {
            return !(a == b);
        }
    }
}
