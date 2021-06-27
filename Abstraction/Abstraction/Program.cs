using System;

namespace Abstraction
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Square : Shape
    {
        private int Side;

        public Square(int side)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * 4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Here, we are unsure how this value 5 is being assigned and
            // this is protecting this 'sq' instance from external altertions
            Square sq = new Square(5);

            // Here, we are unsure, how the area is getting calculated
            // as we do not have access to the internal implementation
            Console.WriteLine($"Square Area: {sq.Area()}");
        }
    }
}
