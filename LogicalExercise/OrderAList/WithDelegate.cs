using System;
using System.Collections.Generic;

namespace logical_exercise.LogicalExercise.OrderAList
{
    public class Employee
    {
        public string name;
        public int age;
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return "[" + name + "," + age + "]";
        }
    }

    public class WithDelegate
    {
        public void Run()
        {
            Employee martin = new Employee("Martin", 29);
            Employee beatriz = new Employee("Beatriz", 25);
            Employee unknow = new Employee("Unknown", 20);
            List<Employee> employees = new List<Employee>() { martin, beatriz, unknow };

            employees.Sort(delegate(Employee x, Employee y) {
                return x.age.CompareTo(y.age);
            });

            Console.WriteLine(String.Join(Environment.NewLine, employees));
        }

    }
}
