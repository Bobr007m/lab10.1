using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure f1 = new GeometricFigure();
            f1.Show();
            GeometricFigure f2 = new GeometricFigure("Прямоугольник");
            f2.Show();
            Rectangle r1 = new Rectangle();
            r1.Show();
            Rectangle r2 = new Rectangle(10,20);
            r2.Show();
            Circle c1 = new Circle();
            c1.Show();
            Circle c2 = new Circle(10);
            c2.Show();
            Parallelepiped p1 = new Parallelepiped();
            p1.Show();
            Parallelepiped p2 = new Parallelepiped(20);
            p2.Show();
            // Создаем массив из 20 объектов
            GeometricFigure[] figures = new GeometricFigure[20];
            Random rnd = new Random();

            // Заполняем массив случайными объектами
            for (int i = 0; i < figures.Length; i++)
            {
                int type = rnd.Next(0, 3); // Случайный выбор типа фигуры
                switch (type)
                {
                    case 0:
                        figures[i] = new Circle();
                        figures[i].RandomInit();
                        break;
                    case 1:
                        figures[i] = new Rectangle();
                        figures[i].RandomInit();
                        break;
                    case 2:
                        figures[i] = new Parallelepiped();
                        figures[i].RandomInit();
                        break;
                }
            }

            // Просмотр массива с помощью обычных функций
            Console.WriteLine("Просмотр массива с помощью обычных функций:");
            foreach (var figure in figures)
            {
                figure.Show(); // Обычный метод Show()
            }

            // Просмотр массива с помощью виртуальных функций
            Console.WriteLine("\nПросмотр массива с помощью виртуальных функций:");
            foreach (var figure in figures)
            {
                if (figure is Circle)
                    ((Circle)figure).Show(); // Виртуальный метод Show() для Circle
                else if (figure is Rectangle)
                    ((Rectangle)figure).Show(); // Виртуальный метод Show() для Rectangle
                else if (figure is Parallelepiped)
                    ((Parallelepiped)figure).Show(); // Виртуальный метод Show() для Parallelepiped
            }

        }
    }
}
