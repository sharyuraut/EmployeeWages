using System;
using System.Collections.Generic;
using System.Text;
using EmployeeWage.Company;

namespace EmployeeWage.Wage
{
    class CompanyWage
    {
        public string Company;
        public int EMP_RATE_PER_HOUR;
        public int NO_OF_WORKING_DAYS;
        public int MAX_MONTHLY_HOURS;
        public int totalEmpWage;

        public CompanyWage(string Company, int EMP_RATE_PER_HOUR, int NO_OF_WORKING_DAYS, int MAX_MONTHLY_HOURS)
        {
            this.Company = Company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NO_OF_WORKING_DAYS = NO_OF_WORKING_DAYS;
            this.MAX_MONTHLY_HOURS = MAX_MONTHLY_HOURS;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for Company " + this.Company + " is:" + this.totalEmpWage;
        }
    }
}
