using EmployeeWages.Company;
using System;
using System.Reflection;
using EmployeeWages.CompanyInterface;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage computation Program!");
            //calling EmployeeWagesBuilder method with required parameters
            EmployeeWagesBuilder empWagesBuilder = new EmployeeWagesBuilder();

            empWagesBuilder.addCompanyEmpWage("XYZ", 12, 8, 10);
            empWagesBuilder.addCompanyEmpWage("ABC", 29, 6, 15);
            empWagesBuilder.computeEmpWage();
            Console.WriteLine("Total Wage for XYZ company : " + empWagesBuilder.getTotalWage("XYZ"));
            Console.WriteLine("Total Wage for ABC company : " + empWagesBuilder.getTotalWage("ABC"));

        }
    }
}
