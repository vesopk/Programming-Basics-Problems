using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchenRoom = double.Parse(Console.ReadLine());
            var squareInchPrice = double.Parse(Console.ReadLine());

            var bathroom = smallestRoom / 2;
            var secondRoom = smallestRoom * 1.1;
            var thirdRoom = secondRoom * 1.1;

            var wholePlace = smallestRoom + kitchenRoom + bathroom + secondRoom + thirdRoom;
            var wholePlace5percent = wholePlace * 0.05;
            var wholePlaceFinal = wholePlace + wholePlace5percent;
            var priceFinal = wholePlaceFinal * squareInchPrice;

            Console.WriteLine("{0:F2}",priceFinal);
        }
    }
}
