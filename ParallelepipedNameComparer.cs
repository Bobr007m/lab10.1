using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    // Для Parallelepiped (сравнение по имени)
    public class ParallelepipedNameComparer : IComparer<Parallelepiped1>
    {
        public int Compare(Parallelepiped1 x, Parallelepiped1 y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
