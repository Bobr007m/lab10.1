using System;
using System.Collections.Generic;

namespace lab10._1
{
    public class Queries
    {
        // 1. Метод для поиска квадратов 
        public static void ShowAllSquares(Geometrycfigure1[] figures)
        {
            Console.WriteLine("Все квадраты и их площади:");

            // Ручной поиск квадратов
            foreach (var figure in figures)
            {
                if (figure is Rectangle1 rect && Math.Abs(rect.Length - rect.Width) < double.Epsilon)
                {
                    double area = rect.Length * rect.Width;
                    Console.WriteLine($"Квадрат '{rect.Name}': Длина = {rect.Length}, Площадь = {area:F2}");
                }
            }
        }

        // 2. Метод для поиска фигур с размером больше заданного
        public static void ShowFiguresWithDimensionGreaterThan(Geometrycfigure1[] figures, double minDimension)
        {
            Console.WriteLine($"\nФигуры с размером > {minDimension}:");

            foreach (var f in figures)
            {
                if (f is Rectangle1 rect && (rect.Length > minDimension || rect.Width > minDimension))
                {
                    Console.WriteLine($"Прямоугольник: {rect.Name} ({rect.Length}x{rect.Width})");
                }
                else if (f is Parallelepiped1 para &&
                        (para.Length > minDimension || para.Width > minDimension || para.Height > minDimension))
                {
                    Console.WriteLine($"Параллелепипед: {para.Name} ({para.Length}x{para.Width}x{para.Height})");
                }
                else if (f is Circle1 circle && circle.Radius > minDimension)
                {
                    Console.WriteLine($"Окружность: {circle.Name} (Радиус = {circle.Radius})");
                }
            }
        }

        // 3. Метод для поиска фигур с радиусом описанной окружности
        public static void ShowFiguresWithRadius(Geometrycfigure1[] figures, double targetRadius)
        {
            Console.WriteLine($"\nФигуры с радиусом описанной окружности = {targetRadius}:");
            bool found = false;

            foreach (var f in figures)
            {
                double? radius = null;

                switch (f)
                {
                    case Rectangle1 rect:
                        radius = Math.Sqrt(rect.Length * rect.Length + rect.Width * rect.Width) / 2;
                        break;
                    case Parallelepiped1 para:
                        radius = Math.Sqrt(para.Length * para.Length +
                                         para.Width * para.Width +
                                         para.Height * para.Height) / 2;
                        break;
                    case Circle1 circle:
                        radius = circle.Radius;
                        break;
                }

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