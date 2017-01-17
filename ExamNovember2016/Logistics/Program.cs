using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());

            var upto3TonsMicrobusPrice = 200;
            var from4TonsTo11TonsPrice = 175;
            var from12TonsAbovePrice = 120;

            var cargoPriceFinalUpto3Tons = 0.0;
            var cargoPriceFinalFrom4TonsTo11Tons = 0.0;
            var cargoPriceFinalFrom12Above = 0.0;
            var cargoWeightUpto3Final = 0.0;
            var cargoWeightFrom4To11Final = 0.0;
            var cargoWeightFrom11AboveFinal = 0.0;
            var cargoWeightFinal = 0.0;
            var price1 = 0.0;
            var price2 = 0.0;
            var price3 = 0.0;
            
          
            
            for (int i = 1; i <= cargoCount; i++)
            {
                int cargoWeigth = int.Parse(Console.ReadLine());

                if (cargoWeigth <=3)
                {
                    cargoPriceFinalUpto3Tons = upto3TonsMicrobusPrice * cargoWeigth;
                    cargoWeightUpto3Final = cargoWeightUpto3Final + cargoWeigth;
                    price1 += cargoPriceFinalUpto3Tons;
                }
                else if (cargoWeigth > 3 && cargoWeigth <= 11)
                {
                    cargoPriceFinalFrom4TonsTo11Tons = from4TonsTo11TonsPrice * cargoWeigth;
                    cargoWeightFrom4To11Final = cargoWeightFrom4To11Final + cargoWeigth;
                    price2 += cargoPriceFinalFrom4TonsTo11Tons;
                }
                else if (cargoWeigth>11)
                {
                    cargoPriceFinalFrom12Above = from12TonsAbovePrice * cargoWeigth;
                    cargoWeightFrom11AboveFinal = cargoWeightFrom11AboveFinal + cargoWeigth;
                    price3 += cargoPriceFinalFrom12Above;

                }
                 cargoWeightFinal = cargoWeightUpto3Final + cargoWeightFrom4To11Final + cargoWeightFrom11AboveFinal;

            }
            var averagePrice = (price1 + price2 + price3) / cargoWeightFinal;
            Console.WriteLine("{0:F2}",averagePrice);
            Console.WriteLine("{0:F2}%",(cargoWeightUpto3Final/cargoWeightFinal)*100);
            Console.WriteLine("{0:F2}%", (cargoWeightFrom4To11Final / cargoWeightFinal) * 100);
            Console.WriteLine("{0:F2}%", (cargoWeightFrom11AboveFinal / cargoWeightFinal) * 100);


        }
    }
}
