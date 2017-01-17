using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourhoodShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quanity = double.Parse(Console.ReadLine());
            var price = 0.0;
            if (item=="coffee")
            {
                if (city=="varna")
                {
                    price = quanity * 0.45;
                    Console.WriteLine(price);
                }
                else if (city == "sofia")
                {
                    price = quanity * 0.50;
                    Console.WriteLine(price);
                }
                else if (city == "plovdiv")
                {
                    price = quanity * 0.40;
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("incorrect city");
                }
            }
            else if (item == "water")
            {
                if (city == "varna")
                {
                    price = quanity * 0.70;
                    Console.WriteLine(price);
                }
                else if (city == "sofia")
                {
                    price = quanity * 0.80;
                    Console.WriteLine(price);
                }
                else if (city == "plovdiv")
                {
                    price = quanity * 0.70;
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("incorrect city");
                }
            }
            else if (item == "beer")
            {
                if (city == "varna")
                {
                    price = quanity * 1.10;
                    Console.WriteLine(price);
                }
                else if (city == "sofia")
                {
                    price = quanity * 1.20;
                    Console.WriteLine(price);
                }
                else if (city == "plovdiv")
                {
                    price = quanity * 1.15;
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("incorrect city");
                }
            }
            else if (item == "sweets")
            {
                if (city == "varna")
                {
                    price = quanity * 1.35;
                    Console.WriteLine(price);
                }
                else if (city == "sofia")
                {
                    price = quanity * 1.45;
                    Console.WriteLine(price);
                }
                else if (city == "plovdiv")
                {
                    price = quanity * 1.30;
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("incorrect city");
                }
            }
            else if (item == "peanuts")
            {
                if (city == "varna")
                {
                    price = quanity * 1.55;
                    Console.WriteLine(price);
                }
                else if (city == "sofia")
                {
                    price = quanity * 1.60;
                    Console.WriteLine(price);
                }
                else if (city == "plovdiv")
                {
                    price = quanity * 1.50;
                    Console.WriteLine(price);
                }
                else
                {
                    Console.WriteLine("incorrect city");
                }
            }
            else
            {
                Console.WriteLine("incorrect item");
            }
        }
    }
}
