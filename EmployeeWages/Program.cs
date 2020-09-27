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
        public const int NUM_OF_WORKING_DAYS = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage computation Program!");

            //Variables
            int empHrs = 0;
            int empWage = 0, totalempWage = 0;

            //Computation
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

            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalempWage = totalempWage + empWage;
            }
            Console.WriteLine("Employee Wage = " + empWage);
            Console.WriteLine("Total Employee Wage = " + totalempWage);
        }
    }
}
