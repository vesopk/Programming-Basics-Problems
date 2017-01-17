using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rocketWidth = 3 * n;
            int dots = (rocketWidth / 2) - 1;
            int dots2 = ((rocketWidth / 2) - n);
            int blankSpaces = 0;
            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(@"{0}/{1}\{0}",new string('.',dots),new string(' ',blankSpaces));
                dots = dots - 1;
                blankSpaces = blankSpaces + 2;
            }
            Console.WriteLine("{0}{1}{0}",new string('.',(rocketWidth/2) - n),new string('*',n*2));

            for (int j = 1; j <= n*2; j++)
            {
                Console.WriteLine("{0}|{1}|{0}",new string('.', dots2),new string('\\',blankSpaces-2));
            }
            int stars = (blankSpaces - 2);
            for (int k = 1; k <=n/2; k++)
            {
                
                Console.WriteLine(@"{0}/{1}\{0}",new string('.', dots2),new string('*',stars));
                dots2--;
                stars = stars + 2;
            }
        }
    }
}
