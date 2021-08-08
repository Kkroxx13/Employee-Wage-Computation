using System;

namespace EmployeeWageComputationProblem
{
    class Program
    {
        public int Wage_Per_Hour = 20;
        int n1;
        float basic_sal1, dearness_all1, comm1, house_rent_all1, govt_tax1, gross_sal1, total_salary1 = 0;
        static void Main(string[] args)
        {
            int Wage_hourly = 30;
            Random random = new Random();
            int day = random.Next(0, 2);

            bool loopContinue = true;
            while (loopContinue)
            {
                Console.WriteLine("1.Program to Check Attendance ");
                Console.WriteLine("2.Program to Get Salary ");
                Console.WriteLine("3.Program to Get Monthly Gross Salary");
                Console.WriteLine("Please select a program");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("WELCOME TO EMPLOYEE DETAILSS PROGRAM TO CHECK ATTENDANCE\n");
                        EmployeeWageDescription employeeS1 = new EmployeeWageDescription();
                        employeeS1.Presenty();
                        break;
                    case 2:
                        Console.WriteLine("WELCOME TO EMPLOYEE DETAILS PROGRAM TO CALCULATE  THE EMPLOYEE WAGE \n");
                        EmployeeWageDescription employeeS2 = new EmployeeWageDescription();
                        employeeS2.Salary();
                        break;
                    case 3:
                        Console.WriteLine("WELCOME TO EMPLOYEE DETAILS PROGRAM\n");
                        EmployeeWageDescription employeeS3 = new EmployeeWageDescription();
                        employeeS3.SalaryGross();
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                if (loopContinue)
                    Console.WriteLine("Please enter a valid choice.");





            }

            /*Console.WriteLine("WELCOME TO EMPLOYEE DETAILS WE WILLE THE EMPLOYEE WAGE AND OTHER DETAILS\n");
        EmployeeWageDescription employeeS= new EmployeeWageDescription();
        employeeS.Presenty();
        employeeS.Salary();
        employeeS.SalaryGross();*/


        }

    }

}