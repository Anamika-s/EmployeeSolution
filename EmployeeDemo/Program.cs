using System;

namespace EmployeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetDetails();
            employee.CalculateNetSalary();
            employee.DisplayDetails();
        }
    }
}
