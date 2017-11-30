namespace Ennui.Api.Util
{
    /// <summary>
    /// Provides a set of utilities relating to math.
    /// </summary>
    public static class MathUtils
    {
        private static float Sign(Vector2<float> p1, Vector2<float> p2, Vector2<float> p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }

        /// <summary>
        /// Determines if a coordinate it within a 2d triangle.
        /// </summary>
        /// <param name="pt">The point to check.</param>
        /// <param name="v1">The first point of the triangle.</param>
        /// <param name="v2">The second point of the triangle.</param>
        /// <param name="v3">The third point of the triangle.</param>
        /// <returns>If the provided point is within the triangle bounds.</returns>
        public static bool PointInTriangle(Vector2<float> pt, Vector2<float> v1, Vector2<float> v2, Vector2<float> v3)
        {
            var b1 = Sign(pt, v1, v2) < 0.0f;
            var b2 = Sign(pt, v2, v3) < 0.0f;
            var b3 = Sign(pt, v3, v1) < 0.0f;
            return ((b1 == b2) && (b2 == b3));
        }
    }
}
