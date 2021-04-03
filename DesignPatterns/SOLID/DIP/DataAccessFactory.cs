using System;
using DesignPatterns.SOLID.DIP;

namespace DesignPatterns.SOLID.DIP
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj(){
            return new EmployeeDataAccess();
        }
    }
}