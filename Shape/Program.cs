using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        public abstract class Shape
        {
            public abstract double GetArea();
        }
        class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;

            }
            public override double GetArea()
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
        class Rectangle : Shape
        {
            private double width;
            private double height;
            public Rectangle(double width,double height)
            {
                this.width = width;
                this.height = height;
            }
            public override double GetArea()
            {
                return width*height;
            }
        }
        static void Main(string[] args)
        {
            Shape circle = new Circle(4);
            Console.WriteLine("Area of circle = "+ circle.GetArea());

            Shape rect = new Rectangle(5,9);
            Console.WriteLine("Area of rectangle = "+rect.GetArea());
        }
    }
}
