using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    public abstract class Geometrycfigure 
    {
        static string[] NameFigure = { "Прямоугольник", "Окружность", "Параллелепипед" };
        //Название фигуры
        public string Name { get; set; }
        public IdNumber Id { get; private set; }

        // Обычный метод Show
        public void Show()
        {
            Console.WriteLine($"Фигура: {Name}");
        }
        // Виртуальный метод для вывода информации о фигуре

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
        public override string ToString() => $"Фигура: {Name}";
        // Реализация IComparable<Geometrycfigure>
        public virtual int CompareTo(Geometrycfigure other)
        {
            if (other == null) return 1;
            return this.Name.CompareTo(other.Name); // Сортировка по имени
        }
        // Класс IdNumber
        public class IdNumber
        {
            private int number;
            private object Id;

            public int Number
            {
                get => number;
                set => number = value < 0 ? 0 : value; // Защита от отрицательных значений
            }

            // Конструктор по умолчанию
            public IdNumber()
            {
                Number = 0;
            }

            // Конструктор с параметром
            public IdNumber(int number)
            {
                Number = number;
            }

            // Переопределение Equals()
            public override bool Equals(object obj)
            {
                if (obj is IdNumber other)
                    return Number == other.Number;
                return false;
            }

            // Переопределение GetHashCode()
            public override int GetHashCode()
            {
                return Number.GetHashCode();
            }

            // Переопределение ToString()
            public override string ToString()
            {
                return $"ID: {Number}";
            }
        }
        public Geometrycfigure ShallowCopy() => (Geometrycfigure)MemberwiseClone();
    }
}
