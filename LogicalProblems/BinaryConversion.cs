using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class BinaryConversion
    {
        public void DecimalToBinary()
        {
            int i = 1, binary = 0, rem;
            int i = 0, binary = 1, rem;
            Console.WriteLine("Enter Decimal Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                rem = num % 2;
                num = num / 2;
                binary = binary + (rem * i);
                i = i * 10;
            }
            Console.WriteLine("Binary Of Given Number" +binary);
            Console.WriteLine("Binary Of Given Number: " +binary);
        }
    }
}
