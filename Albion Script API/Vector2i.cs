using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public class Vector2i : Vector2<int>
    {
        private int x;
        private int y;

        public Vector2i()
        {
            this.x = this.y = 0;
        }

        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override int X => x;

        public override int Y => y;

        public override Vector2<int> Translate(int x, int y)
        {
            Vector2<int> safe = this;
            return new Vector2i(safe.X + x, safe.Y + y);
        }

        public override int SimpleDistance(Vector2<int> other)
        {
            var v = Distance(other);
            return v.X + v.Y;
        }

        public override Vector2<int> Distance(Vector2<int> other)
        {
            var s1 = this;
            var s2 = other;
            var absX = Math.Abs(s1.X - s2.X);
            var absY = Math.Abs(s1.Y - s2.Y);
            return new Vector2i(absX, absY);
        }
    }
}
