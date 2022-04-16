using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class MontlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("Enter The Loan Amount ");
           double principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number Of Years");
            double year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Interest Rate");
            double rateOfInterest = Convert.ToInt32(Console.ReadLine());
            double n = 12 * year;//year in monthly
            double rateOfInterestMonthly = rateOfInterest / (12 * 100);//rate of interest monthly
            double payment =(principal * rateOfInterestMonthly)/(1 - Math.Pow((1 + rateOfInterestMonthly), (-n)));
            Console.WriteLine("Monthly Payment Is: "+payment);
        }
    }
}
