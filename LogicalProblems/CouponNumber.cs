using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class CouponNumber
    {
        public void Coupon()
        {
            int distinct = 0, count = 0;
            Console.WriteLine("Enter the number of distinct coupon: ");
            int couponnumber = Convert.ToInt32(Console.ReadLine());
            bool[] is_collected = new bool[couponnumber]; 
            while(distinct<couponnumber)
            {
                Random random = new Random();
                int option=random.Next(1,100);
                int new_coupon = (int)(random.NextDouble() * couponnumber);
                count++;
                if (!is_collected[new_coupon])
                {
                    distinct++;
                    is_collected[new_coupon] = true;
                }
            }
            Console.WriteLine("Total random number needed to have all distinct coupons: " + count);
        }
    }
}
