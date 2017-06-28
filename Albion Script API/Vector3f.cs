using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public class Vector3f : Vector3<float>
    {
        private float x;
        private float y;
        private float z;

        public Vector3f()
        {
            this.x = this.y = this.z = 0.0f;
        }

        public Vector3f(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override float X => x;

        public override float Y => y;

        public override float Z => z;

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

        public override Vector3<float> Translate(float x, float y, float z)
        {
            Vector3<float> safe = this;
            return new Vector3f(safe.X + x, safe.Y + y, safe.Z + z);
        }

        public override float SimpleDistance(Vector3<float> other)
        {
            var v = Distance(other);
            return v.X + v.Y + v.Z;
        }

        public override Vector3<float> Distance(Vector3<float> other)
        {
            var s1 = this;
            var s2 = other;
            var absX = Math.Abs(s1.X - s2.X);
            var absY = Math.Abs(s1.Y - s2.Y);
            var absZ = Math.Abs(s1.Z - s2.Z);
            return new Vector3f(absX, absY, absZ);
        }

        public override IArea<float> Expand(float x, float y, float z)
        {
            return new Area(Translate(-x, -y, -z), Translate(x, y, z));
        }
    }
}
