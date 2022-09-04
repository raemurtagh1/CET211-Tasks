using System;

namespace HighestIntegerSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int iFirst;
            int iSecond;

            Console.Write("Please enter a number between 1 and 10 - ");
            iFirst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (iFirst == 0 || iFirst > 10)
            {
                Console.WriteLine("The number you have entered is invalid.");
                Console.Write("Please enter another number between 1 and 10 - ");
                iFirst = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            //Clearing Errors
            Console.Clear();
            Console.WriteLine("Please enter a number between 1 and 10 - " + iFirst);
            //End of Clearing Errors

            Console.Write("Please enter another number between 1 and 10 - ");
            iSecond = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            while (iSecond == 0 || iSecond > 10)
            {
                Console.WriteLine("The number you have entered is invalid.");
                Console.Write("Please enter another number between 1 and 10 - ");
                iSecond = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Clear();

            Console.WriteLine("The first number you entered was - " + iFirst);
            Console.WriteLine("The second number you entered was - " + iSecond);
            Console.WriteLine();

            if (iSecond > iFirst)
            {
                Console.WriteLine(" " + iSecond);
                Console.WriteLine(" " + iFirst);

                Console.WriteLine();
                Console.WriteLine(" The numbers have been swapped.");
            }
            else if (iFirst == iSecond)
            {
                Console.WriteLine(" " + iFirst);
                Console.WriteLine(" " + iSecond);

                Console.WriteLine();
                Console.WriteLine(" The numbers are equal.");
            }
            else
            {
                Console.WriteLine(" " + iFirst);
                Console.WriteLine(" " + iSecond);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}