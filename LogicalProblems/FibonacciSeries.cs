using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Enter the number of terms:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {

                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(a);
            }
        }
        public int fibonacciwithrecursion(int num)
        {
            if (num == 1)
            {
                return 0; ;
            }
            if (num == 2)
            {
                return 1;
            }
            else
            {
                return fibonacciwithrecursion(num - 1) + fibonacciwithrecursion(num - 2);
            }
        }
    }
}
    

