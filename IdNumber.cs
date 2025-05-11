using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10._1
{
    // Класс IdNumber
    public class IdNumber
    {
        private int number;

        public int Number
        {
            get => number;
            set => number = value < 0 ? 0 : value; // Защита от отрицательных значений
        }

        public IdNumber() : this(0) { }

        public IdNumber(int number)
        {
            Number = number;
        }

        public override bool Equals(object obj)
        {
            return obj is IdNumber other && Number == other.Number;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID: {Number}";
        }
}
}
