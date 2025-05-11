using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
        // Для Circle (сравнение по имени)
        public class CircleNameComparer : IComparer<Circle1>
        {
            public int Compare(Circle1 x, Circle1 y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
