namespace lab10._1
{
    public class Parallelepiped : Geometrycfigure
    {
        protected double height;
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
        public Parallelepiped()
        {
            height = 1;
        }
        // Конструктор с параметрами
        public Parallelepiped(double height)
        {
            Height = height;
        }
        public override void Init()
        {
            base.Init();
            Console.Write("Введите высоту: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            Height = rnd.Next(1, 100);
        }
        public void Show()
        {
            Console.WriteLine($"Высота = {height}");
            Console.ReadLine();
        }
        public override string ToString() => base.ToString() + $", Высота: {Height}";
        public override int CompareTo(Geometryfigure1 other)
        {
            if (other is Parallelepiped1 otherPara)
                return this.Height.CompareTo(otherPara.Height);
            return base.CompareTo(other);
        }

    }
}