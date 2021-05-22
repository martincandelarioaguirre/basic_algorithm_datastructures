using System;

namespace logical_exercise.LanguageDotNet.Out
{
    public class OutVariables
    {
        public void Run()
        {
            GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
            EmployeeName, Gender, Salary, Department);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            GetEmployeeDetails(out string EmployeeName1, out string Gender1, out long Salary1, out _);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}",
            EmployeeName1, Gender1, Salary1);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Deparmet)
        {
            EmployeeName = "Martin";
            Gender = "Male";
            Salary = 10000;
            Deparmet = "IT";
        }
    }
}