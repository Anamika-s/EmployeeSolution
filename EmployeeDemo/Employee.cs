using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class Employee
    {
        int id;
        string name;
        string dept;
        string manager;
        int exp;
        public string companyName;

        decimal basicSalary;
        decimal dA, hRA, pF, netSalary;
        public void GetDetails()
        {
            Console.WriteLine("Enter Id");
            id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ENter Name");
            name = Console.ReadLine();
            Console.WriteLine("ENter Dept");
            dept = Console.ReadLine();
            Console.WriteLine("ENter Manager");
            manager = Console.ReadLine();
            Console.WriteLine("Enter Exp");
            exp = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter BAsic Salary");
            basicSalary =   Convert.ToDecimal(Console.ReadLine());

        }
        public void CalculateNetSalary()
        {
            if (exp > 10)
            {
                dA = (decimal).1 * basicSalary;
                pF = (decimal).085 * basicSalary;
                hRA = 6200;
            }
            else if (exp > 5 && exp <= 10)
            {
                dA = (decimal).2 * basicSalary;
                pF = (decimal).045 * basicSalary;
                hRA = 5200;

            }
            else
            {
                dA = (decimal).2 * basicSalary;
                pF = (decimal).045 * basicSalary;
                hRA = 5200;

            }
            netSalary = (basicSalary + dA + hRA) - pF;

        }
        public void DisplayDetails()
        {
            Console.WriteLine("ID is " + id);
            Console.WriteLine($"Name is {name}");
             Console.WriteLine($"Dept is {dept}" );
            Console.WriteLine("Basic Salary {0}", basicSalary);
            Console.WriteLine($"Net Salary is {netSalary}");


        }



    }
}
