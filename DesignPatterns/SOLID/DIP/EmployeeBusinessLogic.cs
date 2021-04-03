using System;
using DesignPatterns.SOLID.DIP;

namespace 

DesignPatterns.SOLID.DIP
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic(){
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }

        public Employee GetEmployeeDetails(int id){
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}