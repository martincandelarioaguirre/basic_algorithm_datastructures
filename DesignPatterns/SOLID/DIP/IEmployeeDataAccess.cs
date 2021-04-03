using DesignPatterns.SOLID.DIP;

namespace DesignPatterns.SOLID.DIP
{
    public interface IEmployeeDataAccess
    {
         Employee GetEmployeeDetails(int id);
    }
}