using System;

namespace logical_exercise.LanguageDotNet.Abstract
{
    public abstract class AreaClass {
        abstract public int Area();
        public virtual void TestT(){
            Console.WriteLine("Test");
        }
    }

    public class Square: AreaClass 
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }

        public override int Area()
        {
            return side * side;
        }

        public override void TestT(){
            Console.WriteLine("This is the new defintion of TestT method");
        }

        public void Run() {
            Square s = new Square(6);
            Console.WriteLine($"The square area is: {s.Area()}");
            s.TestT();
        }
    }

}