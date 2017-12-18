using System;

namespace NewYearParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var guestsCount = int.Parse(Console.ReadLine());
            var money = int.Parse(Console.ReadLine());

            var couvertPrice = 20 * guestsCount;

            if (couvertPrice < money)
            {
                var leftMoney = money - couvertPrice;

                var fireworksPrice = leftMoney * 0.4;

                var donationMoney = leftMoney * 0.6;

                Console.WriteLine(
                    $"Yes! {Math.Round(fireworksPrice)} lv are for fireworks and {Math.Round(donationMoney)} lv are for donation.");
            }

            else
            {
                var moneyToGo = couvertPrice - money;

                Console.WriteLine($"They won't have enough money to pay the covert. They will need {moneyToGo} lv more.");
            }
        }
    }
}
