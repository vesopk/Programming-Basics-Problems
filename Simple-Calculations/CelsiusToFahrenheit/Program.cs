﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            double fahrenheitNeeded = Math.Round(fahrenheit, 2);
            Console.WriteLine(fahrenheitNeeded);
        }
    }
}
