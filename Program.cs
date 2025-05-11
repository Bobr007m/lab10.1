using System;
using System.Linq;


namespace lab10._1
{
    public class Program
    {

        // Демонстрационная программа
       
            static void Main()
            {
                Geometrycfigure1 f1 = new Geometrycfigure1();
                f1.Show();
                Geometrycfigure1 f2 = new Geometrycfigure1("Прямоугольник");
                f2.Show();
                Rectangle r1 = new Rectangle();
                r1.Show();
                Rectangle r2 = new Rectangle(10, 20);
                r2.Show();
                Circle1 c1 = new Circle1();
                c1.Show();
                Circle1 c2 = new Circle1(10);
                c2.Show();
                Parallelepiped1 p1 = new Parallelepiped1();
                p1.Show();
                Parallelepiped1 p2 = new Parallelepiped1(20);
                p2.Show();
                // Создаем массив из 20 объектов
                Geometrycfigure1[] figures = new Geometrycfigure1[20];
                Random rnd = new Random();

                // Заполняем массив случайными объектами
                for (int i = 0; i < figures.Length; i++)
                {
                    int type = rnd.Next(0, 3); // Случайный выбор типа фигуры
                    switch (type)
                    {
                        case 0:
                            figures[i] = new Circle1();
                            figures[i].RandomInit();
                            break;
                        case 1:
                            figures[i] = new Rectangle1();
                            figures[i].RandomInit();
                            break;
                        case 2:
                            figures[i] = new Parallelepiped1();
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
                    if (figure is Circle1)
                        ((Circle1)figure).Show(); // Виртуальный метод Show() для Circle
                    else if (figure is Rectangle1)
                        ((Rectangle1)figure).Show(); // Виртуальный метод Show() для Rectangle
                    else if (figure is Parallelepiped1)
                        ((Parallelepiped1)figure).Show(); // Виртуальный метод Show() для Parallelepiped
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
            // Создаем и инициализируем массив фигур
            Geometrycfigure[] figures1 = new Geometrycfigure[20];
            Random rand = new Random();

            for (int i = 0; i < figures1.Length; i++)
            {
                switch (rand.Next(3))
                {
                    case 0: figures1[i] = new Circle(); break;
                    case 1: figures1[i] = new Rectangle(); break;
                    case 2: figures1[i] = new Parallelepiped(); break;
                }
                figures[i].RandomInit();
            }

            // Демонстрация запросов
            Console.WriteLine("Демонстрация запросов");

            // 1. Все квадраты и их площади
            Queries.ShowAllSquares(figures);

            // 2. Фигуры с размером больше 10
            Queries.ShowFiguresWithDimensionGreaterThan(figures, 10);

            // В основной программе
            var figuresI = new Geometrycfigure[]
            {
    new Rectangle(3, 4),    // Радиус описанной окружности = 2.5
    new Rectangle(6, 8),    // Радиус описанной окружности = 5
    new Circle(5),          // Радиус = 5
    new Parallelepiped(3, 4, 5) // Радиус описанной сферы ≈ 4.33
            };

            Queries.ShowFiguresWithRadius(figures, 5);

            // 4. Пример использования typeof для группировки фигур
            Console.WriteLine("\nГруппировка фигур по типу:");
            var groupedFigures = figures.GroupBy(f => f.GetType());
            foreach (var group in groupedFigures)
            {
                Console.WriteLine($"{group.Key.Name}: {group.Count()} шт.");
            }

            // 5. Сортировка и вывод фигур
            Console.WriteLine("\nОтсортированные фигуры по имени:");
            Array.Sort(figures);
            foreach (var figure in figures)
            {
                Console.WriteLine(figure);
            }
        }
        }
    }

