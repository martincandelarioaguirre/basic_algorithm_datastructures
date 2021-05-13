using System;
using System.Threading.Tasks;

namespace logical_exercise.LanguageDotNet.TasksExample
{
    public class TaskReturnValue
    {
        public void Run()
        {
            new Example1().Run();
            new Example2().Run();
            new Example3().Run();
            new Example4().Run();
            new Example5().Run();
        }
    }

    class Example1
    {
        static double CalculateSum(int num)
        {
            double sum = 0;
            for (var count = 1; count <= num; count++)
            {
                sum += count;
            }
            return sum;
        }

        public void Run()
        {
            Console.WriteLine("Main Thread started");
            Task<double> task1 = Task.Run(() =>
            {
                return CalculateSum(10);
            });

            Console.WriteLine($"Sum is: {task1.Result}");
            Console.WriteLine($"Main Thread completed");
            Console.ReadKey();
        }
    }

    class Example2
    {
        public void Run()
        {
            Console.WriteLine("Main Thread started");
            Task<double> task1 = Task.Run(() =>
            {
                double sum = 0;
                for (int count = 1; count <= 10; count++)
                {
                    sum += count;
                }
                return sum;
            });

            Console.WriteLine($"Sum is: {task1.Result}");
            Console.WriteLine($"Main Thread Completed");
            Console.ReadKey();
        }
    }

    class Example3
    {
        public void Run()
        {
            Console.WriteLine($"Main Thread Started");
            Task<Employee> task = Task<Employee>.Factory.StartNew(() =>
            {
                Employee emp = new Employee()
                {
                    ID = 101,
                    Name = "Martin",
                    Salary = 1000
                };
                return emp;
            });
            Employee emp = task.Result;
            Console.WriteLine($"ID: {emp.ID}, Name : {emp.Name}, Salary : {emp.Salary}");
            Console.WriteLine($"Main Thread Completed");
            Console.ReadKey();
        }
    }

    class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public double Salary { set; get; }
    }

    class Example4
    {
        public void Run()
        {
            Task<int> task = Task.Run(() =>
            {
                return 10;
            });

            task.ContinueWith((i) =>
            {
                Console.WriteLine("Task Cancelled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            task.ContinueWith((i) =>
            {
                Console.WriteLine("Task faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = task.ContinueWith((i) =>
            {
                Console.WriteLine("Task completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }

    class Example5 
    {
        public void Run() {
            Task<string> task = Task.Run(() => {
                return 12;
            }).ContinueWith((antecedent) => {
                return $"The square of {antecedent.Result} is: {antecedent.Result * antecedent.Result}";
            });
            Console.WriteLine(task.Result);

        }
    }


}