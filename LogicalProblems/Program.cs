﻿namespace LogicalProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome To Logical Program----------- ");
            bool end = true;
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumber\n3.PrimeNumber\n4.ReverseNumber\n5.TempratureConversion\n6.DayOf Week\n7.End Of The Program");
            while (end == true)
            {
                Console.WriteLine("\nEnter Option For Exicute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        series.fibonacciwithrecursion(10);
                        break;
                    case 2:
                        PerfectNumber number = new PerfectNumber();
                        number.Perfect();
                        break;
                    case 3:
                        PrimeNumber primenumber = new PrimeNumber();
                        primenumber.Prime();
                        break;
                    case 4:
                        ReverseNumber reversenumber = new ReverseNumber();
                        reversenumber.Reverse();
                        break;
                    case 5:
                        Temprature temprature=new Temprature();
                        temprature.CeltoFeh();
                        temprature.FehtoCel();
                        break;
                    case 6:
                        DayOfWeek week = new DayOfWeek();
                        week.Week();
                        break;
                    case 7:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option");
                        break;

                }
            }

        }
    }
}