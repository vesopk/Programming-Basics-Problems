using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var happyDays = double.Parse(Console.ReadLine());
            var weeksReturnHome = double.Parse(Console.ReadLine());
            var weekInYear = 48.0;
            var weekends = (weekInYear - weeksReturnHome) * 3.0 / 4.0;
            var sofiaPlays = happyDays * 2.0 / 3.0;
            var totalGames = weekends + sofiaPlays + weeksReturnHome;
            if (year == "leap") { totalGames = totalGames * 1.15; }
            Console.WriteLine(Math.Truncate(totalGames));
        }
    }
}
