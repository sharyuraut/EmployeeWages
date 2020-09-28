using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage.Company
{
        public class EmployeeCompany
        {
            //Constants
            public const int IS_FULL_TIME = 1;
            public const int IS_PART_TIME = 2;
            public const int PART_TIME = 4;
            public const int FULL_TIME = 8;

            private string Company;
            private int EMP_RATE_PER_HOUR;
            private int NO_OF_WORKING_DAYS;
            private int MAX_MONTHLY_HOURS;
            private int totalEmpWage;

            public EmployeeCompany(string Company, int EMP_RATE_PER_HOUR, int NO_OF_WORKING_DAYS, int MAX_MONTHLY_HOURS)
            {
                this.Company = Company;
                this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
                this.NO_OF_WORKING_DAYS = NO_OF_WORKING_DAYS;
                this.MAX_MONTHLY_HOURS = MAX_MONTHLY_HOURS;
            }

            public void computeEmpWage()
            {
                //Variables
                int empHours = 0;
                int totalEmpHours = 0;
                int totalWorkingDays = 0;

                while (totalEmpHours <= this.MAX_MONTHLY_HOURS && totalWorkingDays < this.NO_OF_WORKING_DAYS)
                {
                    totalWorkingDays++;
                    Random random = new Random();

                    //Computation
                    int empCheck = random.Next(0, 3);

                    //Check Employee Attendance and WorkHours using Switch Case
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            empHours = FULL_TIME;
                            break;

                        case IS_PART_TIME:
                            empHours = PART_TIME;
                            break;

                        default:
                            empHours = 0;
                            break;
                    }

                    //DailyEmployeeWage
                    totalEmpHours += empHours;
                }
                totalEmpWage = totalEmpHours * this.EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Working Days: " + totalWorkingDays + " Total Emp Hours: " + totalEmpHours);
                Console.WriteLine("Total Employee Wage for Company " + Company + " is " + totalEmpWage);
            }

            public string toString()
            {
                return "Total Emp Wage for Company " + this.Company + " is:" + this.totalEmpWage;
            }

        }
}
