﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    internal class Rectangle: GeometricFigure
    {
        protected double length;
        protected double width;
        // Длина прямоугольника
        public double Length
        {
            get
            {return length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Длина не может быть отрицательной или равной 0");
                length = value;
            }
        }
        // Ширина прямоугольника
        public double Width
        {
            get
            { return width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Ширина не может быть отрицательной или равной 0");
                width = value;
            }
        }
        // Площадь прямоугольника
        public double Area ()
        {
            return Width*Length;
        }
// Конструктор по умолчанию, вызывает конструктор базового класса с именем "Прямоугольник"
public Rectangle() : base("Прямоугольник") 
        {
            length = 1;
            width = 1;
        }
        // Конструктор с параметрами
        public Rectangle(double length, double width) : base ("Прямоугольник")
        {
            Length = length;
            Width = width;
        }
        public override void Init()
        {
            base.Init();
            Console.Write("Введите длину: ");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину: ");
            Width = Convert.ToDouble(Console.ReadLine());
        }
        public override void RandomInit()
        {
            base.RandomInit();
            Random rnd = new Random();
            Length = rnd.Next(1, 100);
            Width = rnd.Next(1, 100);
        }
        public override void Show ()
        {
            Console.WriteLine($"Ширина = {width}, длина = {length}");
            Console.ReadLine();
        }
        public override string ToString() => base.ToString() + $", Длина: {Length}, Ширина: {Width}";

    }
}
