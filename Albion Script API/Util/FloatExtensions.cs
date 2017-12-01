using System;

namespace Ennui.Api.Util
{
    public static class FloatExtensions
    {
        public static bool NearlyEquals(this float a, float b, float epsilon = 0.01f)
        {
            if (a != b)
            {
                return Math.Abs(a - b) < epsilon;
            }

            return true;
        }
    }
}
