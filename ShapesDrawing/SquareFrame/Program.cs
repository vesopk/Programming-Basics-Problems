﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");


            for (int col = 1; col <= n-2; col++)
            {
                Console.Write("|");
                for (int row = 1; row <= n - 2; row++)
                {
                    Console.Write(" -");

                }
                Console.WriteLine(" |");
            }

            Console.Write("+");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

        }
    }
}
