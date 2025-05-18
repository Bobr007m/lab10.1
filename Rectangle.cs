using System;


namespace lab10._1
{
    public class Rectangle1 : Geometrycfigure1, IComparable<Rectangle1>
    {
        protected double length;
        protected double width;
        // Реализация IComparable
        public int CompareTo(Rectangle1 other)
        {
            if (other == null) return 1;

            // Сравниваем по площади
            double thisArea = this.Area();
            double otherArea = other.Area();

            return thisArea.CompareTo(otherArea);
        }
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Введите ширину: ");
            Width = SafeReadDouble();
            Console.WriteLine("Введите длину: ");
            length = SafeReadDouble();
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
            length = rnd.NextDouble() * 10 + 1;
        }
        // Длина прямоугольника
        public double Length
        {
            get
            { return length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Длина не может быть отрицательной или равной 0");
                length = value;
            }
        }
        // Ширина прямоугольника
        public double Width
        {
            get
            { return width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Ширина не может быть отрицательной или равной 0");
                width = value;
            }
        }
        // Площадь прямоугольника
        public double Area()
        {
            return Width * Length;
        }
        // Конструктор по умолчанию
        public Rectangle1() : base("Прямоугольник")
        {
            length = 1;
            width = 1;
        }

        // Конструктор с параметрами
        public Rectangle1(double length, double width) : base("Прямоугольник")
        {
            Length = length;
            Width = width;
        }
        public override void Init()
        {
            base.Init();

            Length = ReadPositiveDouble("Введите длину: ");
            Width = ReadPositiveDouble("Введите ширину: ");
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
            Length = rnd.Next(1, 100);
            Width = rnd.Next(1, 100);
        }
        public void Show()
        {
            Console.WriteLine($"Ширина = {width}, длина = {length}");
            Console.ReadLine();
        }
        public override void Show1()
        {
            base.Show1();
            Console.WriteLine($"Длина: {Length}, Ширина: {Width}");
        }
        public override string ToString() => base.ToString() + $", Длина: {Length}, Ширина: {Width}";
        protected override IComparable ComparisonKey => Length * Width;
    }
}