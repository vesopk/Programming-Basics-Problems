﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int k = 1; k < n; k++)
                {
                    Console.Write(" *");
                    Console.WriteLine();
                }
                
            }
        }
    }
}
