using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationProblem
{
    class EmployeeSalary
    {
        public void Salary()
        {
            int Wage_hourly = 20;
            Console.WriteLine("Enter the number of working hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            int wage = hours * Wage_hourly;

            Console.WriteLine($"Employee wage is {wage}");
        }
    }
}
