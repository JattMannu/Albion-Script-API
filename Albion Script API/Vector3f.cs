using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
    /// A concrete vector3 implementation that uses floating point numbers internally.
    /// </summary>
    public class Vector3f : Vector3<float>
    {
        private float x;
        private float y;
        private float z;

        public Vector3f() : this(0.0f, 0.0f, 0.0f) { }

        public Vector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <inheritdoc/>
        public override float X => x;

        /// <inheritdoc/>
        public override float Y => y;

        /// <inheritdoc/>
        public override float Z => z;

        /// <inheritdoc/>
        public override Vector2<float> Translate(float x, float y)
        {
            Vector2<float> safe = this;
            return new Vector2f(safe.X + x, safe.Y + y);
        }

        /// <inheritdoc/>
        public override float SimpleDistance(Vector2<float> other)
        {
            var v = Distance(other);
            return v.X + v.Y;
        }

        /// <inheritdoc/>
        public override Vector2<float> Distance(Vector2<float> other)
        {
            var s1 = this;
            var s2 = other;
            var absX = Math.Abs(s1.X - s2.X);
            var absY = Math.Abs(s1.Y - s2.Y);
            return new Vector2f(absX, absY);
        }

        /// <inheritdoc/>
        public override Vector3<float> Translate(float x, float y, float z)
        {
            Vector3<float> safe = this;
            return new Vector3f(safe.X + x, safe.Y + y, safe.Z + z);
        }

        /// <inheritdoc/>
        public override float SimpleDistance(Vector3<float> other)
        {
            var v = Distance(other);
            return v.X + v.Y + v.Z;
        }

        /// <inheritdoc/>
        public override Vector3<float> Distance(Vector3<float> other)
        {
            var s1 = this;
            var s2 = other;
            var absX = Math.Abs(s1.X - s2.X);
            var absY = Math.Abs(s1.Y - s2.Y);
            var absZ = Math.Abs(s1.Z - s2.Z);
            return new Vector3f(absX, absY, absZ);
        }

        /// <inheritdoc/>
        public override IArea<float> Expand(float x, float y, float z)
        {
            return new Area(Translate(-x, -y, -z), Translate(x, y, z));
        }
    }
}
