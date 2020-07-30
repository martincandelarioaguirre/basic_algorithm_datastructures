using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class Kid : IElement
    {
        public string KidName { set; get; }
        public Kid(string name)
        {
            KidName = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IVisitor
    {
        void Visit(IElement element);
    }

    public class Doctor : IVisitor
    {
        public string Name { set; get; }
        public Doctor(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Doctor: {this.Name} did the health checkup  of the child: {kid.KidName}");
        }
    }

    public class Salesman : IVisitor
    {
        public string Name { set; get; }
        public Salesman(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Salesman: {this.Name} gave the school bag to the child {kid.KidName}");
        }
    }

    public class School
    {
        private static List<IElement> elements;
        static School()
        {
            elements = new List<IElement>{
                new Kid("Ram"),
                new Kid("Sara"),
                new Kid("Pam")
            };
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }

    public class VisitorTest
    {
        public void Run()
        {
            School school = new School();
            var visitor1 = new Doctor("James");
            school.PerformOperation(visitor1);
            Console.WriteLine();
            var visitor2 = new Salesman("John");
            school.PerformOperation(visitor2);
            Console.Read();
        }
    }


}