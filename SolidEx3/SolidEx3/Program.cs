using System;

namespace SolidEx3
{
    //квадрат наслідується від прямокутника!!!
    // Порушено Liskov substitution principle. Ми не можемо використовувати квадрат там, де
    // використовуємо прямокутник (замінити клас базовим), адже метод обчислення площі
    // видає нелогічний з точки зору користувача результат.

    // Щоб вирішити дану проблему, можна визначити інтерфейс IShape

    interface IShape
    {
        int GetRectangleArea();
    }

    class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetRectangleArea()
        {
            return Width * Height;
        }
    }

    class Square : IShape
    {
        public int Side { get; set; }

        public int GetRectangleArea()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Side = 5;

            Console.WriteLine(square.GetRectangleArea());
            Console.ReadKey();
        }
    }
}
