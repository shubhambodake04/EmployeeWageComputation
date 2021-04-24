using System;

namespace EmployeeWageComputation
{
    class Program
    {
       
        static void Main(string[] args)
        {
            EmpWageBuilderObject Dmart = new EmpWageBuilderObject("Dmart", 20, 2, 100);
            EmpWageBuilderObject Relience = new EmpWageBuilderObject("Relience", 10, 4, 20);
            Dmart.computeEmpWage();
            Console.WriteLine(Dmart.ToString());
            Relience.computeEmpWage();
            Console.WriteLine(Relience.ToString());
        }
    }
}
