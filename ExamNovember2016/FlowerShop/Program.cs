using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnoliiPrice = 3.25;
            var zumbuliPrice = 4;
            var roziPrice = 3.50;
            var kaktusiPrice = 8;

            var magnoliiCount = int.Parse(Console.ReadLine());
            var zubuliCount = int.Parse(Console.ReadLine());
            var roziCount = int.Parse(Console.ReadLine());
            var kaktusiCount = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var magnoliiCountPrice = magnoliiCount * magnoliiPrice;
            var zumbuliCountPrice = zubuliCount * zumbuliPrice;
            var roziCountPrice = roziCount * roziPrice;
            var kaktusiCountPrice = kaktusiCount * kaktusiPrice;

            var wholePrice = magnoliiCountPrice + zumbuliCountPrice + roziCountPrice + kaktusiCountPrice;
            var wholePricePercent = wholePrice * 0.05;
            var wholePriceFinal = wholePrice - wholePricePercent;

            if (wholePriceFinal < giftPrice) 
            {
                var notEnoughMoney = giftPrice - wholePriceFinal;
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(notEnoughMoney));
            }
            else
            {
                var spareMoney = wholePriceFinal - giftPrice;
                Console.WriteLine("She is left with {0} leva.",Math.Floor(spareMoney));
            }
           
        }
    }
}
