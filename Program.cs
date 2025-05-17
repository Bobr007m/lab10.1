using System;
using System.Collections.Generic;

namespace lab10._1
{
    public class Program
    {
        static void Main()
        {
            // Инициализация отдельных фигур
            Geometrycfigure1 f1 = new Geometrycfigure1("Базовая фигура");
            f1.Show();

            Rectangle1 r1 = new Rectangle1();
            r1.Show();

            Circle1 c1 = new Circle1();
            c1.Show();

            Parallelepiped1 p1 = new Parallelepiped1();
            p1.Show();

            // Создание и заполнение массива фигур
            Geometrycfigure1[] figures = new Geometrycfigure1[20];
            Random rnd = new Random();

            for (int i = 0; i < figures.Length; i++)
            {
                switch (rnd.Next(3))
                {
                    case 0: figures[i] = new Circle1(); break;
                    case 1: figures[i] = new Rectangle1(); break;
                    case 2: figures[i] = new Parallelepiped1(); break;
                }
                figures[i].RandomInit();
            }

            // 1. Вывод всех фигур
            Console.WriteLine("\nВсе фигуры:");
            foreach (var figure in figures)
            {
                figure.Show();
            }

            // 2. Подсчет количества каждого типа
            int circleCount = 0, rectCount = 0, paraCount = 0;
            foreach (var figure in figures)
            {
                if (figure is Circle1) circleCount++;
                else if (figure is Rectangle1) rectCount++;
                else if (figure is Parallelepiped1) paraCount++;
            }
            Console.WriteLine($"\nКоличество: Круги={circleCount}, Прямоугольники={rectCount}, Параллелепипеды={paraCount}");

            // 3. Сортировка и вывод
            Console.WriteLine("\nОтсортированные фигуры:");
            Array.Sort(figures);
            foreach (var figure in figures)
            {
                Console.WriteLine(figure);
            }

            // 4. Демонстрация запросов
            Console.WriteLine("\nЗапросы:");

            // Все квадраты
            Console.WriteLine("\nВсе квадраты:");
            foreach (var figure in figures)
            {
                if (figure is Rectangle1 rect && rect.Length == rect.Width)
                {
                    Console.WriteLine($"Квадрат {rect.Name}: {rect.Length}x{rect.Width}");
                }
            }

            // Фигуры с размером > 10
            Console.WriteLine("\nФигуры с размером > 10:");
            foreach (var figure in figures)
            {
                if (figure is Circle1 circle && circle.Radius > 10)
                {
                    Console.WriteLine($"Круг {circle.Name}: R={circle.Radius}");
                }
                else if (figure is Rectangle1 rect && (rect.Length > 10 || rect.Width > 10))
                {
                    Console.WriteLine($"Прямоугольник {rect.Name}: {rect.Length}x{rect.Width}");
                }
                else if (figure is Parallelepiped1 para &&
                        (para.Length > 10 || para.Width > 10 || para.Height > 10))
                {
                    Console.WriteLine($"Параллелепипед {para.Name}: {para.Length}x{para.Width}x{para.Height}");
                }
            }

            // Фигуры с радиусом описанной окружности = 5
            Console.WriteLine("\nФигуры с R описанной окружности = 5:");
            foreach (var figure in figures)
            {
                double? radius = null;

                if (figure is Circle1 circle) radius = circle.Radius;
                else if (figure is Rectangle1 rect)
                    radius = Math.Sqrt(rect.Length * rect.Length + rect.Width * rect.Width) / 2;
                else if (figure is Parallelepiped1 para)
                    radius = Math.Sqrt(para.Length * para.Length + para.Width * para.Width + para.Height * para.Height) / 2;

                if (radius.HasValue && Math.Abs(radius.Value - 5) < 0.001)
                {
                    Console.WriteLine($"{figure.Name}: R={radius.Value:F2}");
                }
            }
            // 5. Сортировка с компараторами
            Console.WriteLine("\nСортировка с компараторами:");

            // Круги по радиусу
            var circles = FilterByType<Circle1>(figures);
            Array.Sort(circles, new CircleRadiusComparer());
            Console.WriteLine("\nКруги по радиусу:");
            foreach (var circle in circles)
            {
                Console.WriteLine($"{circle.Name}: R={circle.Radius}");
            }

            // Прямоугольники по площади
            var rectangles = FilterByType<Rectangle1>(figures);
            Array.Sort(rectangles, new RectangleAreaComparer());
            Console.WriteLine("\nПрямоугольники по площади:");
            foreach (var rect in rectangles)
            {
                Console.WriteLine($"{rect.Name}: {rect.Length}x{rect.Width} (S={rect.Length * rect.Width})");
            }
        }

        // Ручная фильтрация по типу 
        private static T[] FilterByType<T>(Geometrycfigure1[] figures) where T : Geometrycfigure1
        {
            var result = new List<T>();
            foreach (var figure in figures)
            {
                if (figure is T typedFigure)
                {
                    result.Add(typedFigure);
                }
            }
            return result.ToArray();
        }
    }
}