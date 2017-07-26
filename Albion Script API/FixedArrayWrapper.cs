using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public class FixedArrayWrapper<T>
    {
        public T[] Values;
        public int Width;
        public int Height;

        public FixedArrayWrapper(T[] values, int width, int height)
        {
            this.Values = values;
            this.Width = width;
            this.Height = height;
        }

        public void Set(int x, int y, T val)
        {
            Values[(((y * Width) + x) * 2) + 1] = val;
        }

        public T Get(int x, int y)
        {
            return Values[(((y * Width) + x) * 2) + 1];
        }
    }
}
