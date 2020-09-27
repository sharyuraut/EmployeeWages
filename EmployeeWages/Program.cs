using System;

namespace EmployeeWages
{
    class Program
    {
        //Constants
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int FULL_TIME = 8;
        public const int PART_TIME = 4;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage computation Program!");

            //Variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    Console.WriteLine("Employee available for part time.");
                    empHrs = PART_TIME;
                    break;
                case IS_FULL_TIME:
                    Console.WriteLine("Employee Present.");
                    empHrs = FULL_TIME;
                    break;
                default:
                    Console.WriteLine("Employee Absent.");
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage = " + empWage);
        }
    }
}
