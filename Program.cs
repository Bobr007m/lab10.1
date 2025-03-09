using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab10._1
{
    public class Program
    {

        // Демонстрационная программа
        class Program
        {
            static void Main()
            {
                Geometrycfigure f1 = new Geometrycfigure();
                f1.Show();
                Geometrycfigure f2 = new Geometrycfigure("Прямоугольник");
                f2.Show();
                Rectangle r1 = new Rectangle();
                r1.Show();
                Rectangle r2 = new Rectangle(10, 20);
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
                Geometrycfigure[] figures = new Geometrycfigure[20];
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
                

                for (int i = 0; i < objects.Length; i++)
                {
                    switch (rnd.Next(4))
                    {
                        case 0: objects[i] = new Circle(); break;
                        case 1: objects[i] = new Rectangle(); break;
                        case 2: objects[i] = new Parallelepiped(); break;
                        case 3: objects[i] = new Car(); break;
                    }
                    objects[i].RandomInit();
                }

                // Вывод через обычные методы
                Console.WriteLine("Вывод через обычные методы:");
                foreach (var obj in objects)
                {
                    if (obj is Shape shape) shape.Show();
                    else if (obj is Car car) car.Show();
                }

                // Вывод через виртуальные методы
                Console.WriteLine("\nВывод через виртуальные методы:");
                foreach (var obj in objects)
                {
                    if (obj is Shape s) s.Show();
                }

                // Подсчет количества объектов каждого типа
                int circleCount = 0, rectCount = 0, paraCount = 0, carCount = 0;
                foreach (var obj in objects)
                {
                    if (obj is Circle) circleCount++;
                    else if (obj is Rectangle) rectCount++;
                    else if (obj is Parallelepiped) paraCount++;
                    else if (obj is Car) carCount++;
                }

                Console.WriteLine("\nКоличество объектов:");
                Console.WriteLine($"Окружностей: {circleCount}");
                Console.WriteLine($"Прямоугольников: {rectCount}");
                Console.WriteLine($"Параллелепипедов: {paraCount}");
                Console.WriteLine($"Автомобилей: {carCount}");
                // Фильтрация только объектов  Geometryfigure1 для сортировки
                Geometrycfigure[] geometryfigure1s = objects.OfType<Geometrycfigure>().ToArray();

                // Сортировка с использованием IComparable
                Array.Sort(Geometrycfigure);

                // Вывод отсортированных объектов
                Console.WriteLine("Отсортированные фигуры:");
                foreach (var figure1 in geometryfigure1)
                {
                    figure1.Show();
                }
                // Для фигур
                Geometryfigure1[] пeometryfigure1 = objects.OfType<Geometryfigure1>().ToArray();
                Array.Sort(shapes);

                // Для автомобилей (отдельный массив)
                Car[] cars = objects.OfType<Car>().ToArray();
                Array.Sort(cars);
                // Поиск круга с радиусом 5.0
                Circle target = new Circle { Radius = 5.0 };
                int index = Array.BinarySearch(circles, target);

                if (index >= 0)
                    Console.WriteLine($"Найден круг с радиусом {circles[index].Radius}");
                else
                    Console.WriteLine("Круг не найден.");
                // Для Rectangle
                var rectangles = objects.OfType<Rectangle>().ToArray();
                Array.Sort(rectangles);
                var searchRect = new Rectangle { Length = 3, Width = 4 };
                int rectIndex = Array.BinarySearch(rectangles, searchRect);
                Console.WriteLine($"Прямоугольник 3x4: {(rectIndex >= 0 ? "найден" : "не найден")}");
                // Для Parallelepiped
                var parallelepipeds = objects.OfType<Parallelepiped>().ToArray();
                Array.Sort(parallelepipeds);
                var searchPara = new Parallelepiped { Height = 7.5 };
                int paraIndex = Array.BinarySearch(parallelepipeds, searchPara);
                Console.WriteLine($"Параллелепипед высотой 7.5: {(paraIndex >= 0 ? "найден" : "не найден")}");
                // Для Car
                var cars = objects.OfType<Car>().ToArray();
                Array.Sort(cars);
                var searchCar = new Car { FuelFlow = 8.0, FuelVolume = 40 };
                int carIndex = Array.BinarySearch(cars, searchCar);
                Console.WriteLine($"Автомобиль с запасом хода 500 км: {(carIndex >= 0 ? "найден" : "не найден")}");

                // Создаем массив объектов
                IInit[] objects = new IInit[20];
                Random rnd = new Random();

                for (int i = 0; i < objects.Length; i++)
                {
                    switch (rnd.Next(4))
                    {
                        case 0: objects[i] = new Circle(); break;
                        case 1: objects[i] = new Rectangle(); break;
                        case 2: objects[i] = new Parallelepiped(); break;
                        case 3: objects[i] = new Car(); break;
                    }
                    objects[i].RandomInit();
                }

                // Сортировка с использованием IComparer
                Console.WriteLine("=== Сортировка с IComparer ===");

                // Для Circle (по имени)
                var circles = objects.OfType<Circle1>().ToArray();
                Array.Sort(circles, new CircleNameComparer());
                Console.WriteLine("\nОкружности (по имени):");
                foreach (var circle in circles)
                    circle.Show();

                // Для Rectangle (по длине)
                var rectangles = objects.OfType<Rectangl1e>().ToArray();
                Array.Sort(rectangles, new RectangleLengthComparer());
                Console.WriteLine("\nПрямоугольники (по длине):");
                foreach (var rect in rectangles)
                    rect.Show();

                // Для Parallelepiped (по имени)
                var parallelepipeds = objects.OfType<Parallelepiped1>().ToArray();
                Array.Sort(parallelepipeds, new ParallelepipedNameComparer());
                Console.WriteLine("\nПараллелепипеды (по имени):");
                foreach (var para in parallelepipeds)
                    para.Show();

                // Для Car (по расходу топлива)
                var cars = objects.OfType<Car>().ToArray();
                Array.Sort(cars, new CarFuelFlowComparer());
                Console.WriteLine("\nАвтомобили (по расходу топлива):");
                foreach (var car in cars)
                    car.Show();
                // Бинарный поиск для Circle
                Circle[] circles = objects.OfType<Circle>().ToArray();
                Array.Sort(circles);
                Circle targetCircle = new Circle { Radius = 5.0 };
                int circleIndex = Array.BinarySearch(circles, targetCircle);
                Console.WriteLine(circleIndex >= 0
                    ? $"Круг найден! Радиус: {circles[circleIndex].Radius:F2}"
                    : "Круг не найден");

                // Бинарный поиск для Rectangle
                Rectangle[] rectangles = objects.OfType<Rectangle>().ToArray();
                Array.Sort(rectangles);
                Rectangle targetRect = new Rectangle { Length = 3, Width = 4 };
                int rectIndex = Array.BinarySearch(rectangles, targetRect);
                Console.WriteLine(rectIndex >= 0
                    ? $"Прямоугольник найден! Площадь: {rectangles[rectIndex].Length * rectangles[rectIndex].Width:F2}"
                    : "Прямоугольник не найден");

                // Бинарный поиск для Parallelepiped
                Parallelepiped[] parallelepipeds = objects.OfType<Parallelepiped>().ToArray();
                Array.Sort(parallelepipeds);
                Parallelepiped targetPara = new Parallelepiped { Height = 7.5 };
                int paraIndex = Array.BinarySearch(parallelepipeds, targetPara);
                Console.WriteLine(paraIndex >= 0
                    ? $"Параллелепипед найден! Высота: {parallelepipeds[paraIndex].Height:F2}"
                    : "Параллелепипед не найден");
                // Бинарный поиск для Car
                Car[] cars = objects.OfType<Car>().ToArray();
                Array.Sort(cars);
                Car targetCar = new Car { FuelFlow = 8.0, FuelVolume = 40 };
                int carIndex = Array.BinarySearch(cars, targetCar);
                Console.WriteLine(carIndex >= 0
                    ? $"Автомобиль найден! Запас хода: {cars[carIndex].CalculateRemainingRange():F2} км"
                    : "Автомобиль не найден");
            }
        }
    }
}
