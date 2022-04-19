using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class CouponNumber
    {
        public void PrintCoupon(int n)
        {
            int count = 0;
            int check = RandomNumber(n);
            Console.WriteLine("The Coupon Number Is:" + n);
            Console.WriteLine("The Random Got:" + check);
            while (n > 0)
            {
                if (check == n)
                {
                    Console.WriteLine("Congratulation!! get the coupon number in first attempt");
                    break;
                }


                count++;
                Console.WriteLine("Count To Get Coupon Number is:" + count);
                n--;
            }
            Console.WriteLine("To Get Distinct Cou opon number,The Number of Times randoom number used: " + count);
        }
        private static int RandomNumber(int n)
        {
            Random random = new Random();
            n=random.Next(1,9);
            return n;
        }
              
    }
}
