using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXercise01_Day02
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Choose employee type: ");
            Console.WriteLine("1.HR");
            Console.WriteLine("2.Admin");
            Console.WriteLine("3.Software developer");

            int employeeType = int.Parse(Console.ReadLine());
            double monthlySalary = CalculateMonthlySalary(employeeType);

            Console.WriteLine("Employee Email: " + email);
            Console.WriteLine("Monthly Salary:$" + monthlySalary);
            Console.ReadKey();
        }

        static double CalculateMonthlySalary(int employeeType, int workingHours = 0, int workingDays = 0, int projectHandles = 0, int extras = 0)
            {
                double baseSalary = 0;

                switch (employeeType)
                {
                    case 1://HR
                        baseSalary = 100;
                        break;
                    case 2://Admin
                        baseSalary = 100;
                        break;
                    case 3://Softwaredeveloper
                        baseSalary = 100;
                        break;
                    default:
                        Console.WriteLine("Invalid employee type");
                        return 0;
                }
                double salary = baseSalary + (workingHours * workingDays) + (projectHandles * 3000) + (extras * 2000);
                return salary;
          

        }
    }
}
