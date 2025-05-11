using System;
using System.Linq;

namespace lab10._1
{
    public class Queries
    {
        // 1. Исправленный метод для поиска квадратов (теперь выводит площади)
        public static void ShowAllSquares(Geometrycfigure1[] figures)
        {
            Console.WriteLine("Все квадраты и их площади:");
            var squares = figures.OfType<Rectangle1>().Where(r => Math.Abs(r.Length - r.Width) < double.Epsilon);

            foreach (var square in squares)
            {
                double area = square.Length * square.Width;
                Console.WriteLine($"Квадрат '{square.Name}': Длина = {square.Length}, Площадь = {area:F2}");
            }
        }

        // 2. Метод для поиска фигур с размером больше заданного
        public static void ShowFiguresWithDimensionGreaterThan(Geometrycfigure1[] figures, double minDimension)
        {
            Console.WriteLine($"\nФигуры с размером > {minDimension}:");
            foreach (var f in figures)
            {
                switch (f)
                {
                    case Rectangle1 rect when rect.Length > minDimension || rect.Width > minDimension:
                        Console.WriteLine($"Прямоугольник: {rect.Name} ({rect.Length}x{rect.Width})");
                        break;
                    case Parallelepiped1 para when para.Length > minDimension ||
                                                 para.Width > minDimension ||
                                                 para.Height > minDimension:
                        Console.WriteLine($"Параллелепипед: {para.Name} ({para.Length}x{para.Width}x{para.Height})");
                        break;
                    case Circle1 circle when circle.Radius > minDimension:
                        Console.WriteLine($"Окружность: {circle.Name} (Радиус = {circle.Radius})");
                        break;
                }
            }
        }

        // 3. Исправленный метод для поиска фигур с радиусом описанной окружности
        public static void ShowFiguresWithRadius(Geometrycfigure1[] figures, double targetRadius)
        {
            Console.WriteLine($"\nФигуры с радиусом описанной окружности = {targetRadius}:");
            bool found = false;

            foreach (var f in figures)
            {
                double? radius = null;

                // Для прямоугольника
                if (f is Rectangle1 rect)
                {
                    radius = Math.Sqrt(rect.Length * rect.Length + rect.Width * rect.Width) / 2;
                }
                // Для параллелепипеда
                else if (f is Parallelepiped1 para)
                {
                    radius = Math.Sqrt(para.Length * para.Length +
                                     para.Width * para.Width +
                                     para.Height * para.Height) / 2;
                }
                // Для окружности
                else if (f is Circle1 circle)
                {
                    radius = circle.Radius;
                }

                // Точное сравнение (без допуска погрешности)
                if (radius.HasValue && radius.Value == targetRadius)
                {
                    Console.WriteLine($"{f.Name}: Радиус описанной окружности = {radius.Value}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Фигур с радиусом описанной окружности = {targetRadius} не найдено.");
            }
        }
    }
}