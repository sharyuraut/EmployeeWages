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
            EmployeeCompany employeeCompany = new EmployeeCompany();

            employeeCompany.addCompanyEmpWage("XYZ", 12, 8, 10);
            employeeCompany.addCompanyEmpWage("ABC", 29, 6, 15);
            employeeCompany.computeEmpWage();           
        }
    }
}
