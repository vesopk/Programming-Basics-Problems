using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonusPointsForEven = 1;
            double bonusPointsForEndingWith5 = 2;
            double bonusPoints = 0.0;
            double totalPoints = 0.0;
            double pointsBelow100 = 5;
            double pointsBetween100and1000 = number * 20 / 100;
            double pointsAbove1000 = number * 10 / 100;
            if (number <= 100) 
            {
                if (number%2==0)
                {
                    bonusPoints = pointsBelow100 + bonusPointsForEven;
                    totalPoints = number + bonusPoints;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
                else if (number%10==5)
                {
                    bonusPoints = pointsBelow100 + bonusPointsForEndingWith5;
                    totalPoints = number + bonusPoints;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
                else {
                    bonusPoints = pointsBelow100;
                    totalPoints = number + bonusPoints;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
            }
            else if (number>100&&number<=1000)
            {
                if (number % 2 == 0)
                {
                    bonusPoints = pointsBetween100and1000 + bonusPointsForEven;
                    totalPoints = bonusPoints + number;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
                else if (number % 10 == 5) 
                {
                    bonusPoints = pointsBetween100and1000 + bonusPointsForEndingWith5;
                    totalPoints = bonusPoints + number;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
                else
                {
                    bonusPoints = pointsBetween100and1000;
                    totalPoints = bonusPoints + number;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
            }
            else if (number > 1000)
            {
                if (number % 2 == 0)
                {
                    bonusPoints = pointsAbove1000 + bonusPointsForEven;
                    totalPoints = bonusPoints + number;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
                else if (number % 10 == 5)
                {
                    bonusPoints = pointsAbove1000 + bonusPointsForEndingWith5;
                    totalPoints = bonusPoints + number;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
                else
                {
                    bonusPoints = pointsAbove1000;
                    totalPoints = bonusPoints + number;
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(totalPoints);
                }
            }
        }
    }
}
