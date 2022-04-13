using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            int rev=0,rem;
            Console.WriteLine("Enter The Number: ");
            int num=Convert.ToInt32(Console.ReadLine());    
            while(num>0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number is "+rev);
        
        }
    }
}
