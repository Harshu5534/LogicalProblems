namespace LogicalProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome To Logical Program----------- ");
            bool end = true;
            Console.WriteLine("1.Fibonacci Series\n2.End Of The Program");
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
                    case 3:
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