using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePriceForKilo = double.Parse(Console.ReadLine());
            double fruitPriceForKilo = double.Parse(Console.ReadLine());
            int vegetableKilos = int.Parse(Console.ReadLine());
            int fruitKilos = int.Parse(Console.ReadLine());
            var vegetableProfit = vegetablePriceForKilo * vegetableKilos;
            var fruitProfit = fruitPriceForKilo * fruitKilos;
            var wholeProfit = vegetableProfit + fruitProfit;
            double profitInEuro = wholeProfit / 1.94;
            Console.WriteLine(profitInEuro);
        }
    }
}
