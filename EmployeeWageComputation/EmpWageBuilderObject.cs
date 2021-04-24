using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHrs;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        private string totalEmpWage;

       
        public EmpWageBuilderObject(string company, int empRatePerHrs, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;

                }


                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "EmpHrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHrs;
            Console.WriteLine("Total Emp Wage for company:" + company + "is:" + totalEmpWage);
        }

        public string toString()
        {
            return "Total emp wage for company:" + this.company + "is:" + this.totalEmpWage;
        }
    }

}
