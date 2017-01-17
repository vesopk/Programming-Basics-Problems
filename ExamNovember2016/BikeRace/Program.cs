using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorRacers = int.Parse(Console.ReadLine());
            int seniorRacers = int.Parse(Console.ReadLine());
            string typeOfRace = Console.ReadLine().ToLower();

            var juniorTrailPrice = 5.50 * juniorRacers;
            var juniorCrossPrice = 8 * juniorRacers;
            var juniorDownHillPrice = 12.25 * juniorRacers;
            var juniorsRoadPrice = 20 * juniorRacers;
            var junior50RacersPlusPriceCross = (8 * 0.75) * juniorRacers;

            var seniorTrailPrice = 7 * seniorRacers;
            var seniorCrossPrice = 9.50 * seniorRacers;
            var seniorDownHillPrice = 13.75 * seniorRacers;
            var seniorRoadPrice = 21.50 * seniorRacers;
            var senior50RacersPlusPriceCross = (9.50 * 0.75) * seniorRacers;

            var tax = 0.0;
            var taxFinal = 0.0;

            var racersCount = juniorRacers + seniorRacers;

            if (typeOfRace == "trail")
            {
                tax = juniorTrailPrice + seniorTrailPrice;
                taxFinal = tax * 0.95;
                Console.WriteLine("{0:F2}",taxFinal);
            }
            else if (typeOfRace == "downhill")
            {
                tax = juniorDownHillPrice + seniorDownHillPrice;
                taxFinal = tax * 0.95;
                Console.WriteLine("{0:F2}", taxFinal);
            }
            else if (typeOfRace=="road")
            {
                tax = juniorsRoadPrice + seniorRoadPrice;
                taxFinal = tax * 0.95;
                Console.WriteLine("{0:F2}", taxFinal);
            }
            else if (typeOfRace == "cross-country" && racersCount >= 50)
            {
                tax = junior50RacersPlusPriceCross + senior50RacersPlusPriceCross;
                taxFinal = tax * 0.95;
                Console.WriteLine("{0:F2}", taxFinal);
            }
            else if (typeOfRace == "cross-country")
            {
                tax = juniorCrossPrice + seniorCrossPrice;
                taxFinal = tax * 0.95;
                Console.WriteLine("{0:F2}", taxFinal);
            }
            
        }
    }
}
