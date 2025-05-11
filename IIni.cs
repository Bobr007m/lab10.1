using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    public interface IIni
    {
        int CompareTo<T>(T searchItem) where T : IIni, new();
        void Init();
        void RandomInit();
    }
}
