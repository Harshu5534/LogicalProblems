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
            int P=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number Of Years");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Interest Rate");
            int R = Convert.ToInt32(Console.ReadLine());
            var n = 12 * Y;
            Console.WriteLine(n);
            float r = R / 1200;
            Console.WriteLine(r);
            double Payment = ((P * r) / (1 -Math.Pow((1 + r),-n)));
            Console.WriteLine("Monthly Payment Is: "+Payment);          

        }
    }
}
