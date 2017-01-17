using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int elevatorRounds = (int) Math.Ceiling((double)peopleCount / elevatorCapacity);
            Console.WriteLine(elevatorRounds);
            
        }
    }
}
