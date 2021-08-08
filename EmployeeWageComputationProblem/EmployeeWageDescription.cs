using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputationProblem
{
    class EmployeeWageDescription
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

        /* 
         * public void Salary()
        {
            int Wage_hourly = 20;
            Console.WriteLine("Enter the number of working hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            int wage = hours * Wage_hourly;

            Console.WriteLine($"Employee wage is {wage}");
        }*/

        public void SalaryGross()
        {
            int n;
            float basic_sal, dearness_all, comm, house_rent_all, govt_tax, gross_sal, total_salary = 0;
            for (n = 1; n <= 3; n++)
            {
                Console.Write("Enter Basic Salary for {0} staff : ", n);
                basic_sal = float.Parse(Console.ReadLine());
                dearness_all = basic_sal * 20 / 100;
                comm = basic_sal * 10 / 100;
                house_rent_all = basic_sal * 25 / 100;
                govt_tax = basic_sal * 20 / 100;
                gross_sal = basic_sal + dearness_all + comm + house_rent_all - govt_tax;
                total_salary = total_salary + gross_sal;
                Console.Write("Basic Salary of Employee = {0} \n", basic_sal);
                Console.Write("Dearness Allowance = {0} \n", dearness_all);
                Console.Write("Commission = {0} \n", comm);
                Console.Write("House Rent Allowance = {0} \n", house_rent_all);
                Console.Write("Government Tax = {0} \n", govt_tax);
                Console.Write("Gross Salary = {0} \n\n", gross_sal);
            }
            Console.Write("\n \n Total Salary Payable to All Staff = {0}", total_salary);

        }
    }
}