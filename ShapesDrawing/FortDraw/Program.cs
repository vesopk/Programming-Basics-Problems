using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int fortSize = int.Parse(Console.ReadLine());
            //Draw fortTop
            int capsCount = fortSize / 2;
            int underSpacesCount;
            if (fortSize % 2 == 0) 
            {
                underSpacesCount = fortSize - 4;
            }
            else
            {
                underSpacesCount = fortSize - 3;
            }

            Console.WriteLine(@"/{0}\{1}/{0}\",new string('^',capsCount),
                new string('_',underSpacesCount));
            //Draw fortMid
            for (int i = 0; i < fortSize - 3; i++)
            {
                Console.WriteLine("|{0}|", new string(' ', fortSize * 2 - 2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ', fortSize - underSpacesCount / 2 - 1),
                new string('_', underSpacesCount));

            //Draw fortBottom
            Console.WriteLine(@"\{0}/{1}\{0}/",new string('_',capsCount),new string(' ',underSpacesCount));
        }
    }
}
