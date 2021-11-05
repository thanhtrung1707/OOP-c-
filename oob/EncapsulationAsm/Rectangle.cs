using System;

namespace EncapsulationAsm
{
    public class Rectangle
    {
        public double Length;
        protected double Width;
        private double Area;

        public Rectangle(double length , double width)
        {
            Length = length;
            Width = width;
        }
        private double GetArea()
        {
            return Length * Width;
        }
        public void Display()
        {
            Console.WriteLine("Area: {0}", GetArea());
        }

      
    }

    
}