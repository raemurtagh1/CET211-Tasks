using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double dStandardPrice = 5.60;
            double dSeniorPrice = 3.20;

            int iNumberOfTickets;
            int iNumberOfNormalTickets;
            int iNumberOfSeniors;
            int iNumberOfSeniorTickets;

            double dTotalPrice;
            double dTotalPriceOfNormalTickets;
            double dTotalPriceOfSeniorTickets;

            Title();

            Console.WriteLine("Cost of Standard Ticket - £5.60");
            Console.WriteLine("Cost of Senior Citizen Ticket - £3.20");
            Console.WriteLine();

            Console.Write("How many tickets would you like in total? ");
            iNumberOfTickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How many seniors are in the group? ");
            iNumberOfSeniors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (iNumberOfSeniors == 0)
            {
                dTotalPrice = iNumberOfTickets * dStandardPrice;

                Console.Clear();
                Title();
                Console.WriteLine("The number of tickets you would like to purchase is: " + iNumberOfTickets);
                Console.WriteLine("The total cost for the tickets is: " + dTotalPrice.ToString("C"));
            }
            else
            {
                iNumberOfNormalTickets = iNumberOfTickets - iNumberOfSeniors;
                iNumberOfSeniorTickets = iNumberOfTickets - iNumberOfNormalTickets;
                dTotalPriceOfNormalTickets = iNumberOfNormalTickets * dStandardPrice;
                dTotalPriceOfSeniorTickets = iNumberOfSeniors * dSeniorPrice;
                dTotalPrice = dTotalPriceOfNormalTickets + dTotalPriceOfSeniorTickets;

                Console.Clear();
                Title();
                Console.WriteLine("The number of standard tickets you would like to purchase is: " + iNumberOfNormalTickets);
                Console.WriteLine("The number of senior tickets you would like to purchase is: " + iNumberOfSeniorTickets);
                Console.WriteLine();
                Console.WriteLine("The total cost for the tickets is: " + dTotalPrice.ToString("C"));
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }

        static void Title()
        {
            Console.WriteLine("********* Welcome to Empire Cinema's! *********");
            Console.WriteLine();
        }
    }
}