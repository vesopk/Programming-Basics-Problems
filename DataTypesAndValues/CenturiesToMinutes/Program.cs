using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuriesCount = int.Parse(Console.ReadLine());
            int centuriesToYears = centuriesCount * 100;
            int yearsToDays = (int)(centuriesToYears * 365.2422);
            int daysToHours = yearsToDays * 24;
            int hoursToMintutes = daysToHours * 60;

            Console.WriteLine($"{centuriesCount} centuries = {centuriesToYears} years = {yearsToDays} days = {daysToHours} hours = {hoursToMintutes} minutes");

        }
    }
}
