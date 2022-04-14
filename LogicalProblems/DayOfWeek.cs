using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class DayOfWeek
    {
        public void Week()
        {

            Console.WriteLine("Enter The Month 1 to 12");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Day 1 to 7");
            int Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Year 4 Digits");
            int Year = Convert.ToInt32(Console.ReadLine());
            int y0 = Year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (Day + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Thuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thuresday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("No Day Found");
                    break;
            }
        }

    }

}
    

