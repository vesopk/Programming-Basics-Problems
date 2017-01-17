using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            double counter199 = 0;
            double counter399 = 0;
            double counter599 = 0;
            double counter799 = 0;
            double counter800 = 0;
            for (int i = 1; i <= numberCount; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (number >= 1 && number < 200)
                {
                    counter199++;
                }
                else if (number >= 200 && number < 400)
                {
                    counter399++;
                }
                else if (number >= 400 && number < 600)
                {
                    counter599++;
                }
                else if (number >= 600 && number < 800)
                {
                    counter799++;
                }
                else
                {
                    counter800++;
                }
            }

            Console.WriteLine("{0:f2}%", (counter199 / numberCount) * 100);
            Console.WriteLine("{0:f2}%", (counter399 / numberCount) * 100);
            Console.WriteLine("{0:f2}%", (counter599 / numberCount) * 100);
            Console.WriteLine("{0:f2}%", (counter799 / numberCount) * 100);
            Console.WriteLine("{0:f2}%", (counter800 / numberCount) * 100);
        
        }
    }
}
