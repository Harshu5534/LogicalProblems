using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Temprature
    {
        public void CeltoFeh()
        {
            int F;
            Console.WriteLine("Enter The Temprature In Celcius.");
            int C = Convert.ToInt32(Console.ReadLine());
            F = (C * 9 / 5) + 32;
            Console.WriteLine("Temprature In Celsius To Fahrenheit Is:" + F);
        }
        public void FehtoCel()
        {
            float c,v;
            Console.WriteLine("Enter The Temprature In Fahrenheit Is.");
            int F = Convert.ToInt32(Console.ReadLine());
            v = (F - 32) * 5;
            c = v/9;
            Console.WriteLine("Temprature In Celsius To Fahrenheit Is:" + c);

        }
    }
}
