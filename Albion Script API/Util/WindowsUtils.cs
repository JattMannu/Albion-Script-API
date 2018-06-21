using System.Runtime.InteropServices;

namespace Ennui.Api.Util
{
    /// <summary>
    /// A set of utilities relating to the windows operating system.
    /// </summary>
    public static class WindowsUtils
    {
        public struct Point
        {
            public int x;
            public int y;
        }

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point pos);
    }
}
