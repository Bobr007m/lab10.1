using System;
namespace lab10._1
{
    public class Parallelepiped1 : Geometrycfigure1
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }
        protected double height;
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Введите ширину: ");
            Width = SafeReadDouble();
            Console.WriteLine("Введите высоту: ");
            Height = SafeReadDouble();
            Console.WriteLine("Введите длину: ");
            Length = SafeReadDouble();
        }
        private double SafeReadDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double result))
                    return result;
                Console.WriteLine("Ошибка ввода! Введите число:");
            }
        }

        public override void RandomInitialize()
        {
            base.RandomInitialize();
            var rnd = new Random();
            Width = rnd.NextDouble() * 10 + 1;
            Height = rnd.NextDouble() * 10 + 1;
            Length = rnd.NextDouble() * 10 + 1;
        }
        // Высота параллелепипеда
        public double Height
        {
            get
            { return height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Высота не может быть отрицательной или равной 0");
                height = value;
            }
        }
        // Конструктор по умолчанию, вызывает конструктор базового класса с именем "Параллелепипед"
        public Parallelepiped1() : base("Параллелепипед")
        {
            Name = "Параллелепипед";
            Length = 1;
            Width = 1;
            Height = 1;
        }
        // Конструктор с параметрами
        public Parallelepiped1(double length, double width, double height) : base("Параллелепипед")
        {
            Length = length;
            Width = width;
            Height = height;
        }
        // Метод для вычисления площади поверхности
        public double CalculateSurfaceArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        // Метод для вычисления объема
        public double CalculateVolume()
        {
            return Length * Width * Height;
        }
        public override void Show1()
        {
            base.Show1();
            Console.WriteLine($"Размеры: {Length} x {Width} x {Height}");
            Console.WriteLine($"Площадь поверхности: {CalculateSurfaceArea():F2}");
            Console.WriteLine($"Объем: {CalculateVolume():F2}");
        }
        public override void Init()
        {
            base.Init();
            Length = ReadPositiveDouble("Введите длину: ");
            Width = ReadPositiveDouble("Введите ширину: ");
            Height = ReadPositiveDouble("Введите высоту: ");
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
            Height = rnd.Next(1, 100);
        }
        public override string ToString() => base.ToString() + $", Высота: {Height}";
        protected override IComparable ComparisonKey => Length * Width * Height;

    }
}