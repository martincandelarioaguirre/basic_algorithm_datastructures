using System;

namespace DesignPatterns.Behavioral
{
    public abstract class HouseTemplate
    {
        // Template method defines the sequence for building a house
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
            Console.WriteLine("House is build");
        }
        // Methods to be implemented by subclasses
        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();
    }

    public class ConcreteHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Bulding foundation with cement, iron rods and sand");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Building concrete pillars with cement and sand");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building Concrete walls");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Bulding Concrete windows");
        }
    }

    public class WoodenHouse : HouseTemplate
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation with cemente, iron rods, wood and sand");
        }

        protected override void BuildPillars()
        {
            Console.WriteLine("Building wood pillars with wood coating");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building wood walls");
        }

        protected override void BuildWindows()
        {
            Console.WriteLine("Building wood windows");
        }
    }

    public class TemplateMehodTest {
        public void Run(){
            Console.WriteLine("Build a Concrete House \n");
            HouseTemplate houseTemplate = new ConcreteHouse();
            // call the template method
            houseTemplate.BuildHouse();
            Console.WriteLine();
            Console.WriteLine("Build a Wooden House \n");
            houseTemplate = new WoodenHouse();
            // call the template method
            houseTemplate.BuildHouse();
            Console.Read();
        }
    }
}