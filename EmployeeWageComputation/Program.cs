using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wages Computation ");
            int fullTime = 1;
            int partTime = 2;
            int empRate = 20;

            int empHrs = 0;
            int empPartHrs = 0;
            int empWage = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == fullTime)
                empHrs = 8;
            else if (empCheck == partTime)
                empPartHrs = 4;

            empWage = empHrs * empRate;
            empPartHrs = empPartHrs * empRate;
            Console.WriteLine("Emp Full Time Wage: " + empWage);
            Console.WriteLine("Emp part Time Wage:" + empPartHrs);
            Console.ReadKey();
        }
    }
}
