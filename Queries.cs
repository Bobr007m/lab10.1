using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    internal class Queries
    {
        public static void ShowAllSquares(GeometricFigure[] figures)
        {
            Console.WriteLine("Все площади квадратов:");
            foreach (var f in figures)
            {
                // Используем оператор is для проверки типа
                if (f is Rectangle)
                {
                    // Приводим фигуру к типу Rectangle с помощью as
                    Rectangle rect = f as Rectangle;
                    if (rect != null && rect.Length == rect.Width) // Проверяем, что это квадрат
                    {
                        Console.WriteLine($"Квадрат: {rect.Name}");
                    }
                }
            }
        }
        public static void ShowFiguresWithDimensionGreaterThan(GeometricFigure[] figures, double minDimension)
        {
            Console.WriteLine($"Фигуры с длиной/шириной/высотой не меньше {minDimension}:");
            foreach (var f in figures)
            {
                if (f is Rectangle rect && (rect.Length >= minDimension || rect.Width >= minDimension))
                {
                    Console.WriteLine(rect);
                }
                else if (f is Parallelepiped parallelepiped && parallelepiped.Height >= minDimension)
                {
                    Console.WriteLine(parallelepiped);
                }
            }
        }
        public static void ShowFiguresWithRadius(GeometricFigure[] figures, double radius)
        {
            Console.WriteLine($"Фигуры с радиусом описанной окружности, равным {radius}:");
            foreach (var f in figures)
            {
                // Используем оператор is для проверки типа
                if (f is Circle)
                {
                    // Приводим фигуру к типу Circle с помощью as
                    Circle circle = f as Circle;
                    if (circle != null && circle.Radius == radius)
                    {
                        Console.WriteLine(circle);
                    }
                }
            }
        }
    }
}
