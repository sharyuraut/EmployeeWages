using System;
using System.Collections.Generic;
using System.Text;
using EmployeeWages.Wage;

namespace EmployeeWages.CompanyInterface
{
    public class EmployeeWagesBuilder : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int PART_TIME = 4;
        public const int FULL_TIME = 8;

        private LinkedList<CompanyWage> CompanyWageList;
        private Dictionary<string, CompanyWage> compantToEmpWageMap;

        public EmployeeWagesBuilder()
        {
            this.CompanyWageList = new LinkedList<CompanyWage>();
            this.compantToEmpWageMap = new Dictionary<string, CompanyWage>();
        }

        public void addCompanyEmpWage(string Company, int EMP_RATE_PER_HOUR, int NO_OF_WORKING_DAYS, int MAX_MONTHLY_HOURS)
        {
           CompanyWage CompanyWage = new CompanyWage(Company, EMP_RATE_PER_HOUR, NO_OF_WORKING_DAYS, MAX_MONTHLY_HOURS);
            this.CompanyWageList.AddLast(CompanyWage);
            this.compantToEmpWageMap.Add(Company, CompanyWage);
        }
        public void computeEmpWage()
        {
            foreach(CompanyWage CompanyWage in this.CompanyWageList)
            {
                CompanyWage.setTotalEmpWage(this.computeEmpWage(CompanyWage));
                Console.WriteLine(CompanyWage.toString());
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
                        empHours = FULL_TIME;
                        break;

                    case IS_PART_TIME:
                        empHours = PART_TIME;
                        break;

                    default:
                        empHours = 0;
                        break;
                }

                //DailyEmployeeWages
                totalEmpHours += empHours;
                Console.WriteLine("Total Working Days: " + totalWorkingDays + " Total Emp Hours: " + totalEmpHours);
            }
            return totalEmpHours * CompanyWage.EMP_RATE_PER_HOUR;
        }
        
        public int getTotalWage(string Company)
        {
            return this.compantToEmpWageMap[Company].totalEmpWage;
        }

    }
}
