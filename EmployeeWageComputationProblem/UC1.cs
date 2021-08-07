using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationProblem
{
    class EmployeeDetails
    {


        public void Presenty()
        {
            int full_day = 1;
            Random random = new Random();
            int day = random.Next(0, 2);

            if (day == full_day)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

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
