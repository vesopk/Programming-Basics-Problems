﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExelentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade>=5.50&&grade<=6.00)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
