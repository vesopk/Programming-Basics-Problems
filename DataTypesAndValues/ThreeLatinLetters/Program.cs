using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int lettersCount = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + lettersCount; i++)
            {
                for (char k = 'a'; k < 'a'+ lettersCount; k++)
                {
                    for (char o = 'a'; o < 'a' + lettersCount; o++)
                    {
                        Console.WriteLine($"{i}{k}{o}");
                    }
                }
            }
            
        }
    }
}
