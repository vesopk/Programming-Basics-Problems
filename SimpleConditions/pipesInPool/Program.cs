using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());
            var pipeOneFill = int.Parse(Console.ReadLine());
            var pipeTwoFill = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var pipesFillComb = (pipeOneFill + pipeTwoFill)* hours;
            var pipeOneFillInPercents = (pipeOneFill * hours / pipesFillComb)* 100 ;
            var pipeTwoFillInPercents =  (pipeTwoFill * hours / pipesFillComb)* 100 ;
            var poolLitersFilledInPercents = (pipesFillComb / volume) * 100 ;

            if (volume >= pipesFillComb) 
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", poolLitersFilledInPercents, (int)
                pipeOneFillInPercents, (int)pipeTwoFillInPercents);
            }
            else
            {
                var litersAbove = pipesFillComb - volume;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hours ,(int) litersAbove);
            }
            
        }
    }
}
