using System;

namespace FamilyIvanovi
{
    class Program
    {
        static void Main(string[] args)
        {
            var madamIvanovaMoney = decimal.Parse(Console.ReadLine());
            var firstChildPresentPrice = decimal.Parse(Console.ReadLine());
            var secondChildPresentPrice = decimal.Parse(Console.ReadLine());
            var thirdChildPresentPrice = decimal.Parse(Console.ReadLine());

            var donation = madamIvanovaMoney - firstChildPresentPrice - secondChildPresentPrice -
                           thirdChildPresentPrice;
            donation *= 0.9M;

            Console.WriteLine($"{donation:F2}");
        }
    }
}
