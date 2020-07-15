using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural
{
    public class EmployeeA
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Designation { set; get; }
        public decimal Salary { set; get; }
        public EmployeeA(int id, string name, string designation, decimal salary)
        {
            ID = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }
    }

    public class ThirdPartyBillingSystem
    {
        // ThirdPartyBillingSystem accepts employees information as a List to process each employe salary
        public void ProcessSalary(List<EmployeeA> listEmployee)
        {
            foreach (var item in listEmployee)
            {
                Console.Write($"RS.{item.Salary} Salary credited to {item.Name} Account");
            }
        }
    }

    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }

    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;
            List<EmployeeA> listEmployee = new List<EmployeeA>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Designation = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                listEmployee.Add(new EmployeeA(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }
            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }

    public class AdapterTest
    {
        public void Run()
        {
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employeesArray);
            Console.Read();
        }
    }
}