using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    /// <summary>
    /// A concrete vector2 implementation that uses 32 bit integers internally.
    /// </summary>
    public class Vector2i : Vector2<int>
    {
        public Vector2i() : this(0, 0) { }

        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <inheritdoc/>
        public override int X { get; set; }

        /// <inheritdoc/>
        public override int Y { get; set; }

        /// <inheritdoc/>
        public override Vector2<int> Translate(int x, int y)
        {
            Vector2<int> safe = this;
            return new Vector2i(safe.X + x, safe.Y + y);
        }

        /// <inheritdoc/>
        public override int SimpleDistance(Vector2<int> other)
        {
            var v = Distance(other);
            return v.X + v.Y;
        }

        /// <inheritdoc/>
        public override Vector2<int> Distance(Vector2<int> other)
        {
            var s1 = this;
            var s2 = other;
            var absX = Math.Abs(s1.X - s2.X);
            var absY = Math.Abs(s1.Y - s2.Y);
            return new Vector2i(absX, absY);
        }

        /// <inheritdoc/>
        public override void Set(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
