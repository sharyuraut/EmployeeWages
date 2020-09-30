using System;
using System.Collections.Generic;
using System.Text;
using EmployeeWage.Wage;

namespace EmployeeWage.Company
{
    public class EmployeeCompany
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int noOfCompany = 0;
        private CompanyWage[] CompanyWageArray;

        public EmployeeCompany()
        {
            this.CompanyWageArray = new CompanyWage[5];
        }

        public void addCompanyEmpWage(string Company, int EMP_RATE_PER_HOUR, int NO_OF_WORKING_DAYS, int MAX_MONTHLY_HOURS)
        {
            CompanyWageArray[this.noOfCompany] = new CompanyWage(Company, EMP_RATE_PER_HOUR, NO_OF_WORKING_DAYS, MAX_MONTHLY_HOURS);
            noOfCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                CompanyWageArray[i].setTotalEmpWage(this.computeEmpWage(this.CompanyWageArray[i]));
                Console.WriteLine(this.CompanyWageArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyWage CompanyWage)
        {
            //Variables
            int empHours = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours <= CompanyWage.MAX_MONTHLY_HOURS && totalWorkingDays < CompanyWage.NO_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();

                //Computation
                int empCheck = random.Next(0, 3);

                //Check Employee Attendance and WorkHours using Switch Case
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;

                    case IS_PART_TIME:
                        empHours = 4;
                        break;

                    default:
                        empHours = 0;
                        break;
                }

                //DailyEmployeeWage
                totalEmpHours += empHours;
                Console.WriteLine("Total Working Days: " + totalWorkingDays + " Total Emp Hours: " + totalEmpHours);
            }
            return totalEmpHours * CompanyWage.EMP_RATE_PER_HOUR;
        }
    }
}

