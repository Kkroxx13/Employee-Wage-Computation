using System;

namespace EmployeeWageComputationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int full_day = 1;
            Random random = new Random();
            int day = random.Next(0, 2);

            if(day==full_day)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
