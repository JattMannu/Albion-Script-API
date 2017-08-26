namespace Ennui.Api.Util
{
    /// <summary>
    /// Represents a 3d coordinate.
    /// </summary>
    /// <typeparam name="T">The type of number to use internally.</typeparam>
    public abstract class Vector3<T> : Vector2<T>
    {
        /// <summary>
        /// The 3d coordinate's z axis.
        /// </summary>
        public abstract T Z { get; set; }

        /// <summary>
        /// Creates a new vector3 that's offset by the provided amount.
        /// </summary>
        /// <param name="x">The amount to offset on the x axis.</param>
        /// <param name="y">The amount to offset on the y axis.</param>
        /// <param name="z">The amount to offset on the z axis.</param>
        /// <returns>The new, translated vector3.</returns>
        public abstract Vector3<T> Translate(T x, T y, T z);

        /// <summary>
        /// Calculates the total distance from this vector3, and the provided vector3.
        /// </summary>
        /// <param name="other">The vector3 to calculate the distance from.</param>
        /// <returns>The distance from the other vector3.</returns>
        public abstract T SimpleDistance(Vector3<T> other);

        /// <summary>
        /// Calculates the actual distance from this vector3, and the provided vector3
        /// </summary>
        /// <param name="other">The vector3 to calculate the distance from.</param>
        /// <returns>The distance from the other vector3.</returns>
        public abstract Vector3<T> Distance(Vector3<T> other);

        /// <summary>
        /// Creates an area with the provided radius, where this vector3 is the center.
        /// </summary>
        /// <param name="x">The x radius of the area.</param>
        /// <param name="y">The y radius of the area.</param>
        /// <param name="z">The z radius of the area.</param>
        /// <returns>The created area.</returns>
        public abstract IArea<T> Expand(T x, T y, T z);

        /// <inheritdoc/>
		public override string ToString()
        {
            return "[Vector3 - " + X + ", " + Y + ", " + Z + "]";
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

            if (object.ReferenceEquals(this, b))
            {
                return true;
            }

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

            if (object.ReferenceEquals(a, b))
            {
                return true;
            }

            return a.X.Equals(b.X) && a.Y.Equals(b.Y) && a.Z.Equals(b.Z);
        }

        /// <inheritdoc/>
        public static bool operator !=(Vector3<T> a, Vector3<T> b)
        {
            return !(a == b);
        }
    }
}
