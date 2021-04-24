using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 100;
        public const int NO_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_THE_MONTH = 10;
        private static int totalEmpWage;

        static void Main(string[] args)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= MAX_HRS_IN_THE_MONTH && totalWorkingDays < NO_OF_WORKING_DAYS)
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
             totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);

        }
    }
}
