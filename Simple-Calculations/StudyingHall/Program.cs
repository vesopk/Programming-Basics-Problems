using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            int hInCentimetersNeeded = (int)(h * 100)/120;
            int wInCentimetersNeeded = (int)((w * 100)-100)/70;
           double workingPlaces = (hInCentimetersNeeded * wInCentimetersNeeded) - 3;
            Console.WriteLine(workingPlaces);
        }
    }
}
