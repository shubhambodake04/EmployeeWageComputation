using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        
        public static int computeEmpWage(string company, int empRatePerHrs, int numOfWorkingdays, int maxHrsPerMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < numOfWorkingdays)
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
                Console.WriteLine("Days#:" + totalWorkingDays + "EmpHrs :" + empHrs + "Company :" + company);
            }
             int totalEmpWage = totalEmpHrs * empRatePerHrs;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            computeEmpWage("Dmart",20,2,100);
            computeEmpWage("Relience",10,4,20);
        }
    }
}
