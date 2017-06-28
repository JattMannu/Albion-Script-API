using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public class Vector2f : Vector2<float>
    {
        private float x;
        private float y;

        public Vector2f()
        {
            this.x = this.y = 0.0f;
        }

        public Vector2f(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override float X => x;

        public override float Y => y;

        public override Vector2<float> Translate(float x, float y)
        {
            Vector2<float> safe = this;
            return new Vector2f(safe.X + x, safe.Y + y);
        }

        public override float SimpleDistance(Vector2<float> other)
        {
            var v = Distance(other);
            return v.X + v.Y;
        }

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
