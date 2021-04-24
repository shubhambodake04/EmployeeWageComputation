using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
                Console.WriteLine("Employe is Present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadKey();
        }
    }
}
