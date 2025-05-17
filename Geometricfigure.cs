using System;
using System.Collections.Generic;


namespace lab10._1
{
    public class Geometrycfigure1 : ICloneable, IComparable<Geometrycfigure1>, IFigureInitializer
    {
        static string[] NameFigure = { "Прямоугольник", "Окружность", "Параллелепипед" };

        //Название фигуры
        public string Name { get; set; }
        public IdNumber Id { get; private set; }
        // Реализация IFigureInitializer
        public virtual void Initialize()
        {
            Console.Write("Введите название фигуры: ");
            Name = Console.ReadLine();
        }

        public virtual void RandomInitialize()
        {
            var rnd = new Random();
            Name = "Фигура_" + rnd.Next(1000);
        }

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
        // Виртуальное свойство для сравнения
        protected virtual IComparable ComparisonKey => Name;

        // Реализация IComparable<Geometrycfigure1>
        public int CompareTo(Geometrycfigure1 other)
        {
            if (other == null) return 1;

            // Сначала сравниваем по типу фигуры
            int typeCompare = GetType().Name.CompareTo(other.GetType().Name);
            if (typeCompare != 0) return typeCompare;

            // Затем по ComparisonKey, если типы совпадают
            return Comparer<IComparable>.Default.Compare(ComparisonKey, other.ComparisonKey);
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
