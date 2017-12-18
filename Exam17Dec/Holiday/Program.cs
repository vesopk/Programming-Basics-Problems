using System;

namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysCount = int.Parse(Console.ReadLine());
            var destination = Console.ReadLine();
            var transportType = Console.ReadLine();

            var totalPrice = 0M;

            if (daysCount >= 1 && daysCount <= 10)
            {
                switch (destination)
                {
                    case "Miami":
                        var miamiPrice = daysCount * ((2 * 24.99M) + (3 * 14.99M));
                        totalPrice += miamiPrice;
                        break;
                    case "Canary Islands":
                        var canaryIslandsPrice = daysCount * ((2 * 32.5M) + (3 * 28.5M));
                        totalPrice += canaryIslandsPrice;
                        break;
                    case "Philippines":
                        var philipinesPrice = daysCount * ((2 * 42.99M) + (3 * 39.99M));
                        totalPrice += philipinesPrice;
                        break;
                }
            }
            else if (daysCount >= 11 && daysCount <= 15)
            {
                switch (destination)
                {
                    case "Miami":
                        var miamiPrice = daysCount * ((2 * 22.99M) + (3 * 11.99M));
                        totalPrice += miamiPrice;
                        break;
                    case "Canary Islands":
                        var canaryIslandsPrice = daysCount * ((2 * 30.5M) + (3 * 25.6M));
                        totalPrice += canaryIslandsPrice;
                        break;
                    case "Philippines":
                        var philipinesPrice = daysCount * ((2 * 41M) + (3 * 36M));
                        totalPrice += philipinesPrice;
                        break;
                }
            }
            else if (daysCount > 15)
            {
                switch (destination)
                {
                    case "Miami":
                        var miamiPrice = daysCount * ((2 * 20M) + (3 * 10M));
                        totalPrice += miamiPrice;
                        break;
                    case "Canary Islands":
                        var canaryIslandsPrice = daysCount * ((2 * 28M) + (3 * 22M));
                        totalPrice += canaryIslandsPrice;
                        break;
                    case "Philippines":
                        var philipinesPrice = daysCount * ((2 * 38.5M) + (3 * 32.4M));
                        totalPrice += philipinesPrice;
                        break;
                }
            }

            totalPrice *= 1.25M;

            switch (transportType)
            {
                case "train":
                    var trainPrice = 2 * 22.3M + 3 * 12.5M;
                    totalPrice += trainPrice;
                    break;
                case "bus":
                    var busPrice = 2 * 45M + 3 * 37M;
                    totalPrice += busPrice;
                    break;
                case "airplane":
                    var airplanePrice = 2 * 90M + 3 * 68.5M;
                    totalPrice += airplanePrice;
                    break;
            }

            Console.WriteLine($"{totalPrice:F3}");
        }
    }
}
