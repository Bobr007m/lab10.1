using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    // Для Parallelepiped (сравнение по объёму)
    public class ParallelepipedVolumeComparer : IComparer<Parallelepiped1>
    {
        public int Compare(Parallelepiped1 x, Parallelepiped1 y)
        {
            double volumeX = x.Length * x.Width * x.Height;
            double volumeY = y.Length * y.Width * y.Height;
            return volumeX.CompareTo(volumeY);
        }
    }
}
