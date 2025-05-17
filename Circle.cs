using System;


namespace lab10._1
{
    public class Circle1 : Geometrycfigure1
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
        public Circle1() : base("Окружность")
        {
            radius = 1;
        }
        public Circle1(double radius) : base("Окружность")
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
            Radius = ReadPositiveDouble("Введите радиус: ");
        }
        private double ReadPositiveDouble(string prompt) //проверка
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out double result) && result > 0)
                    return result;

                Console.WriteLine("Ошибка! Введите положительное число.");
            }
        }
        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            Radius = rnd.Next(1, 100);
        }

        public void Show()
        {
            Console.WriteLine($"Окружность с радиусом {radius}");
        }
        public override void Show1()
        {
            base.Show1();
            Console.WriteLine($"Радиус: {Radius}");
        }
        public override string ToString() => base.ToString() + $", Радиус: {Radius}";
        protected override IComparable ComparisonKey => Radius;
    }
}
