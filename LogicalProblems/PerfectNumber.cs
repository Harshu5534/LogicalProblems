using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int rem, sum = 0;
            Console.WriteLine("Enter The Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                rem = num % i;
                if (rem == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("It Is Perfect Number");
            }
            else
            {
                Console.WriteLine("Is Not Perfect Number");
            }

        }
    }
}
