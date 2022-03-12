using System;
using System.Collections.Generic;
using System.Text;

namespace logical_exercise.LogicalExercise.OrderAList
{
    public class WithLambda
    {
        public void Run()
        {
            Employee john = new Employee("John", 24);
            Employee sam = new Employee("Sam", 27);
            Employee roger = new Employee("Roger", 21);

            List<Employee> employees = new List<Employee>() { john, sam, roger };
            employees.Sort((x,y) => x.age.CompareTo(y.age));

            Console.WriteLine(String.Join(Environment.NewLine, employees));

        }
    }
}
