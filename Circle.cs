using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    public class Circle: GeometricFigure
    {
        protected double radius;
        // Радиус окружности
        public double Radius
        {
            get
            { return radius; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным или равным 0");
                radius = value;
            }
        }
        // Конструктор по умолчанию, вызывает конструктор базового класса с именем "Окружность"
        public Circle() : base("Окружность")
        {
            radius = 1;
        }
        public Circle(double radius) : base("Окружность")
        {
            Radius = radius;
        }
        // Площадь окружности
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Init()
        {
            base.Init();
            Console.Write("Введите радиус: ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }
        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            Radius = rnd.Next(1, 100);
        }

        public override void Show()
        {
            Console.WriteLine($"Окружность с радиусом {radius}");
        }
        public override string ToString() => base.ToString() + $", Радиус: {Radius}";
    }
}
