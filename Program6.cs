using System;

namespace WhileLoop_AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int number = 0;
            int sum = 0;
            double Average = 0.0;

            Console.WriteLine("*** Finding the average of a set of numbers ***");
            Console.WriteLine();

            Console.WriteLine("Please input a set of numbers finishing with 0.");
            Console.WriteLine();

            do
            {
                Console.Write("Number {0}: ", i);
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                ++i;
            }

            while (number != 0);

            Average = sum / 10.0;

            Console.WriteLine();
            Console.WriteLine("The average of the numbers is: " + Average);

            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
