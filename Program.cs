using System;

namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Use Case #9: Compute and Save Total Employee Wage for Multiple Companies");
            Console.WriteLine("Use Case #10: Employee Wage for Multiple Companies using Interface Approach");
            Console.WriteLine("Use Case #11: Employee Wage of Multiple Companies using API Approach");
            Console.WriteLine("Use Case #12: Saving Lists of Multiple Companies");
            Console.WriteLine("Use Case #13: Store Daily and Total Employee Wage");
            Console.WriteLine("Use Case #14: Get Total Employee Wage when Queried by Company");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 9:
                    EmpBuilderObject flipkart = new EmpBuilderObject("Flipkart", 20, 10, 60);
                    EmpBuilderObject amazon = new EmpBuilderObject("Amazon", 20, 15, 80);
                    flipkart.CalculateMonthlyWage();
                    Console.WriteLine(flipkart.ToString());
                    amazon.CalculateMonthlyWage();
                    Console.WriteLine(amazon.ToString());
                    break;
                case 10:
                    EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
                    empWageBuilder.addCompanyEmpWage("Flipkart", 20, 10, 60);
                    empWageBuilder.addCompanyEmpWage("Amazon", 20, 15, 80);
                    empWageBuilder.computeEmpWage();
                    break;
                case 11:
                    EmpWageBuilder empWageBuilderOne = new EmpWageBuilder();
                    empWageBuilderOne.addCompanyEmpWage("Flipkart", 20, 10, 60);
                    empWageBuilderOne.computeEmpWage();
                    empWageBuilderOne.addCompanyEmpWage("Amazon", 20, 15, 80);
                    empWageBuilderOne.computeEmpWage();
                    break;
                case 12:
                    EmpWageBuilderUCTwelve empWageBuilderUCTwelve = new EmpWageBuilderUCTwelve();
                    empWageBuilderUCTwelve.addCompanyEmpWage("Flipkart", 20, 10, 60);
                    empWageBuilderUCTwelve.computeEmpWage();
                    empWageBuilderUCTwelve.addCompanyEmpWage("Amazon", 20, 15, 80);
                    empWageBuilderUCTwelve.computeEmpWage();
                    break;
                case 13:
                    EmpWageBuilderUCThirteen empWageBuilderUCThirteen = new EmpWageBuilderUCThirteen();
                    empWageBuilderUCThirteen.addCompanyEmpWage("Flipkart", 20, 10, 60);
                    empWageBuilderUCThirteen.computeEmpWage();
                    empWageBuilderUCThirteen.addCompanyEmpWage("Amazon", 20, 15, 80);
                    empWageBuilderUCThirteen.computeEmpWage();
                    break;
                case 14:
                    EmpWageBuilderUCFourteen empWageBuilderUCFourteen = new EmpWageBuilderUCFourteen();
                    empWageBuilderUCFourteen.addCompanyEmpWage("Flipkart", 20, 10, 60);
                    empWageBuilderUCFourteen.addCompanyEmpWage("Amazon", 20, 15, 80);
                    empWageBuilderUCFourteen.computeEmpWage();
                    int dmartTotalWage = empWageBuilderUCFourteen.getTotalWage("Flipkart");
                    Console.WriteLine("Total wage for Flipkart: " + dmartTotalWage);
                    int flipkartTotalWage = empWageBuilderUCFourteen.getTotalWage("Amazon");
                    Console.WriteLine("Total wage for Amazon: " + flipkartTotalWage);
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }
        }
    }
}