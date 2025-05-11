using System;


namespace lab10._1
{
    public class Geometrycfigure1 : ICloneable    
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
        public virtual void Show1()
        {
            Console.WriteLine($"Фигура: {Name}");
        }
        public Geometrycfigure1(string name)
        {
            Name = name;
            Id = new IdNumber(0);
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
        public override string ToString() => $"Фигура: {Name}";
        // Реализация IComparable<Geometrycfigure>
        public virtual int CompareTo(Geometrycfigure1 other)
        {
            if (other == null) return 1;
            return this.Name.CompareTo(other.Name); // Сортировка по имени
        }


        // Реализация интерфейса ICloneable
        public virtual object Clone()
        {
            // Создаем поверхностную копию 
            var copy = (Geometrycfigure1)MemberwiseClone();

            // Копируем изменяемые ссылочные типы
            copy.Id = new IdNumber(Id.Number);

            return copy;
        }
    }
}
