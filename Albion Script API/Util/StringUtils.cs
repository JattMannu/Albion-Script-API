using System.Text;

namespace Ennui.Api.Util
{
    public static class StringUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sb">The builder to append to.</param>
        /// <param name="pfx">The prefix to append.</param>
        /// <param name="dgt">What the size of the digit should be.</param>
        /// <param name="val">The numerical value to append.</param>
        public static void AppendWithPadding(StringBuilder sb, string pfx, int dgt, long val)
        {
            sb.Append(pfx);
            if (dgt > 1)
            {
                int pad = (dgt - 1);
                for (long xa = val; xa > 9 && pad > 0; xa /= 10)
                {
                    pad--;
                }

                for (int xa = 0; xa < pad; xa++)
                {
                    sb.Append('0');
                }
            }
            sb.Append(val);
        }
    }
}
