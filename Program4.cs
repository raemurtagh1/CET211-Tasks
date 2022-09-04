using System;

namespace T_Shirt_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int iTshirt_Stock = 50;
            int iHoodie_Stock = 35;

            int iLimited_ED_Tshirts_Wanted;
            int iLimited_ED_Hoodies_Wanted;

            int iTie_Dye_Tshirts_Wanted;
            int iTie_Dye_Hoodies_Wanted;

            int iTotal_Shirts_Wanted;
            int iTotal_Hoodies_Wanted;

            int iStockLeft_ForTshirts;
            int iStockLeft_ForHoodies;
            
            Console.WriteLine("********** Stock Control System **********");
            Console.WriteLine();

            Console.WriteLine("Questions - ");
            Console.WriteLine();

            //T-shirts
            Console.Write("How many limited edition t-shirts has the customer purchased? ");
            iLimited_ED_Tshirts_Wanted = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How many tie-die shirts has the customer purchased? ");
            iTie_Dye_Tshirts_Wanted = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            iTotal_Shirts_Wanted = iLimited_ED_Tshirts_Wanted + iTie_Dye_Tshirts_Wanted;

            //Hoodies
            Console.Write("How many limited edition hoodies has the customer purchased? ");
            iLimited_ED_Hoodies_Wanted = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How many tie-die hoodies has the customer purchased? ");
            iTie_Dye_Hoodies_Wanted = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            iTotal_Hoodies_Wanted = iLimited_ED_Hoodies_Wanted + iTie_Dye_Hoodies_Wanted;

            //Totals
            Console.Clear();

            Console.WriteLine("********** Stock Control System **********");
            Console.WriteLine();

            Console.WriteLine("Totals - ");
            Console.WriteLine();

            Console.WriteLine("The total amount of t-shirts purchased is: " + iTotal_Shirts_Wanted);
            Console.WriteLine();

            Console.WriteLine("The total amount of hoodies purchased is: " + iTotal_Hoodies_Wanted);
            Console.WriteLine();
            Console.WriteLine();

            iStockLeft_ForTshirts = iTshirt_Stock - iTotal_Shirts_Wanted;
            iStockLeft_ForHoodies = iHoodie_Stock - iTotal_Hoodies_Wanted;

            Console.WriteLine("The number of remaining shirts left in total are: " + iStockLeft_ForTshirts);
            Console.WriteLine();

            Console.WriteLine("The number of remaining hoodies left in total are: " + iStockLeft_ForHoodies);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}
