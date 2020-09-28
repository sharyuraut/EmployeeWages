using EmployeeWage.Company;
using System;
using System.Reflection;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage computation Program!");

            //calling computeWage method with required parameters
            EmployeeCompany XYZ = new EmployeeCompany("XYZ", 12, 8, 10);
            EmployeeCompany ABC = new EmployeeCompany("ABC", 29, 6, 15);
            XYZ.computeEmpWage();
            Console.WriteLine(XYZ.toString());
            ABC.computeEmpWage();
            Console.WriteLine(ABC.toString());
        }
    }
}
