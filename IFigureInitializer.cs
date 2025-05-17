using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    public interface IFigureInitializer
    {
        void Initialize();       // Стандартная инициализация
        void RandomInitialize(); // Случайная инициализация
    }
}
