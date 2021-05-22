using System;

namespace logical_exercise.LanguageDotNet.PatternMatching
{
    public class PatternMatching
    {

        public void Run()
        {
            Circle circle = new Circle(10);
            DisplayAreaWithExpression(circle);
            DisplayAreaWuthSwitch(circle);
            Rectangle rectangle = new Rectangle(10, 5);
            DisplayAreaWithExpression(rectangle);
            DisplayAreaWuthSwitch(rectangle);
            Triangle triangle = new Triangle(10, 5);
            DisplayAreaWithExpression(triangle);
            DisplayAreaWuthSwitch(triangle);
            Console.ReadKey();
        }

        public static void DisplayAreaWithExpression(Shape shape)
        {
            if (shape is Circle c)
            {
                Console.WriteLine("Are of Circle is: " + c.Radius * c.Radius * Shape.PI);
            }
            else if (shape is Rectangle r)
            {
                Console.WriteLine("Are of Rectangle is: " + r.Length * r.Height);
            }
            else if (shape is Triangle t)
            {
                Console.WriteLine("Area of Triangle is: " + 0.5 * t.Base * t.Height);
            }
            else
            {
                throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }

        public static void DisplayAreaWuthSwitch(Shape shape)
        {
            switch (shape)
            {
                case Circle c:
                    Console.WriteLine("Are of Circle is: " + c.Radius * c.Radius * Shape.PI);
                    break;
                case Rectangle r:
                    Console.WriteLine("Are of Rectangle is: " + r.Length * r.Height);
                    break;
                case Triangle t:
                    Console.WriteLine("Area of Triangle is: " + 0.5 * t.Base * t.Height);
                    break;
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
                case null:
                    throw new ArgumentNullException(nameof(shape));
            }

        }
    }

    public class Shape
    {
        public const float PI = 3.14f;
    }

    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; }
        public double Height { get; }
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }

    public class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }

}