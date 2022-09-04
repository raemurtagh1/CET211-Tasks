using System;

namespace TheatreTicketSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNumbersOfSeats;
            int iSeatArea;
            double dTotalPrice;

            Title();

            Console.Write("How many seats would you like to purchase? ");
            iNumbersOfSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What area would you like to sit in?");
            Console.WriteLine();

            Console.WriteLine("1. Stalls - £24");
            Console.WriteLine("2. Grand Circle - £30");
            Console.WriteLine("3. Upper Circle - £27");
            Console.WriteLine("4. Gallery - £20");

            Console.WriteLine();
            Console.Write("Please enter the number of your selection: ");
            iSeatArea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (iSeatArea > 4)
            {
                Console.WriteLine("ERROR!!");
                Console.WriteLine("Please select one of the options by typing in the number of the option.");
                Console.Write("Please enter the number of your selection: ");
                iSeatArea = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Clear();
            Title();

            switch (iSeatArea)
            {
                case 1:
                    Console.WriteLine("You have selected " + iNumbersOfSeats + " seats in the Stalls.");
                    dTotalPrice = iNumbersOfSeats * 24;
                    Console.WriteLine();
                    Console.WriteLine("Your total for the tickets will be: " + dTotalPrice.ToString("C"));
                    break;
                case 2:
                    Console.WriteLine("You have selected " + iNumbersOfSeats + " seats in the Grand Circle.");
                    dTotalPrice = iNumbersOfSeats * 30;
                    Console.WriteLine();
                    Console.WriteLine("Your total for the tickets will be: " + dTotalPrice.ToString("C"));
                    break;
                case 3:
                    Console.WriteLine("You have selected " + iNumbersOfSeats + " seats in the Upper Circle.");
                    dTotalPrice = iNumbersOfSeats * 27;
                    Console.WriteLine();
                    Console.WriteLine("Your total for the tickets will be: " + dTotalPrice.ToString("C"));
                    break;
                case 4:
                    Console.WriteLine("You have selected " + iNumbersOfSeats + " seats in the Gallery.");
                    dTotalPrice = iNumbersOfSeats * 20;
                    Console.WriteLine();
                    Console.WriteLine("Your total for the tickets will be: " + dTotalPrice.ToString("C"));
                    break;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }

        static void Title()
        {
            Console.WriteLine("***** Welcome to Empire Theatre! *****");
            Console.WriteLine();
        }
    }
}
