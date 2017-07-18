using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
    /// A concrete vector2 implementation that uses floating point numbers internally.
    /// </summary>
    public class Vector2f : Vector2<float>
    {
        private float x;
        private float y;

        public Vector2f() : this(0.0f, 0.0f) { }

        public Vector2f(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <inheritdoc/>
        public override float X => x;

        /// <inheritdoc/>
        public override float Y => y;

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
    }
}
