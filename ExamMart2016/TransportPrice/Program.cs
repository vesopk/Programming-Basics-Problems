using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMart2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            double bestPrice;
            var taxiStart = 0.70;
            var taxiDay = 0.79;
            var taxiNight = 0.90;
            var busPrice = 0.09;
            var trainPrice = 0.06;
            if (distance < 20 && partOfTheDay == "day")
            {
                bestPrice = taxiStart + distance * taxiDay;
                Console.WriteLine(bestPrice);
            }
            else if (distance < 20 && partOfTheDay == "night")
            {
                bestPrice = taxiStart + distance * taxiNight;
                Console.WriteLine(bestPrice);
            }
            else if (distance >= 20 && distance < 100 && (partOfTheDay == "day" || partOfTheDay == "night"))
            {
                bestPrice = distance * busPrice;
                Console.WriteLine(bestPrice);
            }

            else if (distance >= 100 && (partOfTheDay == "day" || partOfTheDay == "night")) 
            {
                bestPrice = distance * trainPrice;
                Console.WriteLine(bestPrice);
            }

        }
    }
}
