using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrimeNumber
    {
        public void Prime()
        {
            int k = 0;
            Console.WriteLine("Enter The Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if ((num % i) == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            { 
                Console.WriteLine("IS Prime Number.");
            }
            else
            {
                    Console.WriteLine("Is Not Prime Number.");

            }
        }
    }
}
