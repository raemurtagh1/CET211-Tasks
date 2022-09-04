using System;
using System.Diagnostics.CodeAnalysis;

namespace ForLoop_AddNumbers
{
    class Program
    {
        static void Main()
        {
            int i;
            int number;
            int sum = 0;

            Console.WriteLine("*** Inputting 5 numbers, adding them and showing the total ***");
            Console.WriteLine();

            Console.WriteLine("Please input 5 random numbers.");
            Console.WriteLine();

            for (i=1;i<=5;i++)
            {
                Console.Write("Number {0}: ", i);
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine();
            Console.WriteLine("The total of the 5 numbers is: " + sum);

            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
