using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            int priceCrystal = 5;
            int totalCrystal = 20;
            int totalGold;
            int wantsToBuyCrystal;

            Console.Write("How much gold do you have?:");
            totalGold = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Today one crystal costs  {priceCrystal} gold. We have only {totalCrystal} crystals." +
                $" How many crystals do you want to buy?:");
            wantsToBuyCrystal = Convert.ToInt32(Console.ReadLine());

            bool enougtGold = totalGold >= wantsToBuyCrystal * priceCrystal;
            bool enougtCrystal = totalCrystal >= wantsToBuyCrystal;

            wantsToBuyCrystal *= Convert.ToInt32(enougtGold) * Convert.ToInt32(enougtCrystal);

            totalGold -= wantsToBuyCrystal * priceCrystal;
            totalCrystal -= wantsToBuyCrystal;

            Console.WriteLine($"You have  gold left: {totalGold}");
            Console.WriteLine($"Crystals left in the store: {totalCrystal}");
        }
    }
}
