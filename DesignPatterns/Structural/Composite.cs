using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural
{
    public interface IComponent
    {
        void DisplayPrice();
    }

    public class Leaf : IComponent
    {
        public int Price { set; get; }
        public string Name { set; get; }
        public Leaf(string name, int price)
        {
            this.Price = price;
            this.Name = name;
        }

        public void DisplayPrice()
        {
            Console.WriteLine($"{Name} : {Price}");
        }
    }

    public class Composite : IComponent
    {
        public string Name { set; get; }
        List<IComponent> components = new List<IComponent>();
        public Composite(string name)
        {
            this.Name = name;
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }

    public class CompositeTest
    {
        public void Run()
        {
            // Creating Lef Objects
            IComponent hardDisk = new Leaf("HArd Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);

            // Creating composite objects
            Composite motherboard = new Composite("Peripherals");
            Composite cabinect = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            // Creating tree structure
            // Adding CPU and RAM in motherboard
            motherboard.AddComponent(cpu);
            motherboard.AddComponent(ram);

            // Addin motherboard and hard disk in cabinet
            cabinect.AddComponent(motherboard);
            cabinect.AddComponent(hardDisk);

            // Adding mouse and keyboard in peripherals
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);

            // Adding cabinet and perfipherals in computer
            computer.AddComponent(cabinect);
            computer.AddComponent(peripherals);

            // To display the price of computer
            computer.DisplayPrice();
            Console.WriteLine();

            // To display the price of keyboard
            keyboard.DisplayPrice();
            Console.WriteLine();

            // To display the price of cabinet
            cabinect.DisplayPrice();

            Console.Read();

        }
    }

}