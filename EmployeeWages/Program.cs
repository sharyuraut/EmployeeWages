using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage computation Program!");

            //Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int FULL_TIME = 8;

            Random random = new Random();

            //Computations
            int empCheck = random.Next(0, 2);

            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Employee daily Wages = " + EMP_RATE_PER_HOUR*FULL_TIME);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Employee daily Wages = 0");
            }
        }
    }
}
