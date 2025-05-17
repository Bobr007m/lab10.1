using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    // Для Circle (сравнение по радиусу)
    public class CircleRadiusComparer : IComparer<Circle1>
    {
        public int Compare(Circle1 x, Circle1 y)
        {
            if (x == null) return y == null ? 0 : -1;
            if (y == null) return 1;
            return x.Radius.CompareTo(y.Radius);
        }
    }
}
