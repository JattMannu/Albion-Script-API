namespace Ennui.Api.Util
{
    public static class MathUtils
    {
        public static float Sign(Vector2<float> p1, Vector2<float> p2, Vector2<float> p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }

        public static bool PointInTriangle(Vector2<float> pt, Vector2<float> v1, Vector2<float> v2, Vector2<float> v3)
        {
            var b1 = Sign(pt, v1, v2) < 0.0f;
            var b2 = Sign(pt, v2, v3) < 0.0f;
            var b3 = Sign(pt, v3, v1) < 0.0f;
            return ((b1 == b2) && (b2 == b3));
        }
    }
}
