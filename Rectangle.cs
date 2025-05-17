using System;


namespace lab10._1
{
    public class Rectangle1 : Geometrycfigure1
    {
        protected double length;
        protected double width;
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