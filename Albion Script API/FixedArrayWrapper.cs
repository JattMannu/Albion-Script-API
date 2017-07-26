using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public class FixedArrayWrapper<T>
    {
        private T[] values;
        private int width;
        private int height;

        public FixedArrayWrapper(T[] values, int width, int height)
        {
            this.values = values;
            this.width = width;
            this.height = height;
        }

        public void Set(int x, int y, T val)
        {
            values[(((y * width) + x) * 2) + 1] = val;
        }

        public T Get(int x, int y)
        {
            return values[(((y * width) + x) * 2) + 1];
        }
    }
}
