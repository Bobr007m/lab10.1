using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    internal class GeometricFigure
    {
        //Название фигуры
        public string Name { get; set; }

        // Конструктор по умолчанию
        public GeometricFigure() { }
        // Конструктор с параметром для инициализации названия фигуры и площади
        public GeometricFigure(string name)
        {
            Name = "Фигура";
        }
        // Обычный метод Show
        public void Show()
        {
            Console.WriteLine($"Фигура: {Name}");
        }
        // Виртуальный метод для вывода информации о фигуре
        public virtual void Show()
        {
            Console.WriteLine($"Фигура: {Name}");
            Console.ReadLine();
        }
        public virtual void Init()
        {
            Console.Write("Введите название фигуры: ");
            Name = Console.ReadLine();
        }
        public virtual void RandomInit()
        {
            Random rnd = new Random();
            Name = "Фигура_" + rnd.Next(1, 100);
        }
        public override bool Equals(object obj)
        {
            if (obj is GeometricFigure figure)
            {
                return Name == figure.Name;
            }
            return false;
        }
        public override string ToString() => $"Фигура: {Name}";
    }
}
