using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public static class FloatExtensions
    {
        public static bool NearlyEquals(this float a, float b, float epsilon = 0.001f)
        {
            if (a != b)
            {
                return Math.Abs(a - b) < epsilon;
            }

            return true;
        }
    }
}
