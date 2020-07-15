using System;

namespace DesignPatterns.Creational
{
    public class Employee
    {
        public string Name { set; get; }
        public string Department { set; get; }
        public Employee GetClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

    public class PrototypeTest
    {
        public void Run()
        {
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";

            Employee emp2 = emp1.GetClone();
            emp2.Name = "Pranaya";

            Console.WriteLine("Employee 1");
            Console.WriteLine($"Name {emp1.Name}, Department {emp1.Department}");
            Console.WriteLine("Employee 2");
            Console.WriteLine($"Name {emp2.Name}, Department {emp2.Department}");

        }
    }
}