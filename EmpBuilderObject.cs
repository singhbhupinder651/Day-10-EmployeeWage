using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpBuilderObject
    {
        public const int PRESENT_FULL_TIME = 1;
        public const int PRESENT_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;
        }

        public void CalculateMonthlyWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            

            while (totalWorkingDays < this.numOfWorkingDays && totalEmpHrs <= this.maxHoursPerMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case PRESENT_FULL_TIME:
                        Console.WriteLine("Employee Present: Full Time");
                        empHrs = 8;
                        break;
                    case PRESENT_PART_TIME:
                        Console.WriteLine("Employee Present: Part Time");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee Absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);
        }

        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
