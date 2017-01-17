﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterFly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfStarsOrMinuses = n - 2;
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(@"{0}\ /{0}", new string('*', numberOfStarsOrMinuses));
                }
                else
                {
                    Console.WriteLine(@"{0}\ /{0}", new string('-', numberOfStarsOrMinuses));
                }
            }
            Console.WriteLine("{0}{1}",new string(' ',n-1),"@");
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('*', numberOfStarsOrMinuses));
                }
                else
                {
                    Console.WriteLine(@"{0}/ \{0}", new string('-', numberOfStarsOrMinuses));
                }
            }
        }
    }
}
