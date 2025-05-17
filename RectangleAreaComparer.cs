using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    // Для Rectangle (сравнение по площади)
    public class RectangleAreaComparer : IComparer<Rectangle1>
    {
        public int Compare(Rectangle1 x, Rectangle1 y)
        {
            double areaX = x.Length * x.Width;
            double areaY = y.Length * y.Width;
            return areaX.CompareTo(areaY);
        }
    }
}
