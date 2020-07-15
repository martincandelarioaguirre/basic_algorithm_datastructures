using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural
{
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public string Color { set; get; }
        private int xCor = 10;
        private int YCor = 20;
        private int Radius = 30;
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public void Draw()
        {
            Console.WriteLine($"Circle: Draw() [Color: {Color} X cor : {xCor}, Ycor: {YCor}, Radius : {Radius}]");
        }
    }

    public class ShapeFactory
    {
        public static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();
        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;
            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (shapeMap.TryGetValue("circle", out shape))
                {

                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add("circle", shape);
                    Console.WriteLine("Creating circle object with out any color in shapeFactory");
                }
            }
            return shape;
        }
    }

    public class FlyweightTest
    {
        public void Run()
        {
            Console.WriteLine("\n Red color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Red");
                circle.Draw();
            }
            Console.WriteLine("\n Green color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Green");
                circle.Draw();
            }
            Console.WriteLine("\n Blue color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Green");
                circle.Draw();
            }
            Console.WriteLine("\n Orange color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Orange");
                circle.Draw();
            }
            Console.WriteLine("\n Black color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Black");
                circle.Draw();
            }
            Console.ReadKey();
        }
    }

}