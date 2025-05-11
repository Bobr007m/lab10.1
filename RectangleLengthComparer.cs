using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    // Для Rectangle (сравнение по длине)
    public class RectangleLengthComparer : IComparer<Rectangle1>
    {
        public int Compare(Rectangle1 x, Rectangle1 y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
