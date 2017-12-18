using System;

namespace Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysToRun = int.Parse(Console.ReadLine());
            var firstDayKm = double.Parse(Console.ReadLine());
            var totalKm = firstDayKm;

            for (int i = 0; i < daysToRun; i++)
            {
                var currentDayPercentage = int.Parse(Console.ReadLine());
                var distanceToAdd = firstDayKm * ((double)currentDayPercentage / 100);
                firstDayKm += distanceToAdd;
                totalKm += firstDayKm;
            }

            Console.WriteLine(totalKm >= 1000
                ? $"You've done a great job running {Math.Ceiling((totalKm - 1000))} more kilometers!"
                : $"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKm)} more kilometers");
        }
    }
}
