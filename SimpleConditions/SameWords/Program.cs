﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();
            if (firstWord.ToLower()==secondWord.ToLower())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
