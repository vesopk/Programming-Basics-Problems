using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConventror2
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();
            double total = 0;
            switch (inputCurrency)
            {
                case "USD" :
                    switch (outputCurrency)
                    {
                        case "BGN": total = amount * 1.79549; break;
                        case "EUR": total = (amount * 1.79549) / 1.95583; break;
                        case "GBP": total = (amount * 1.79549) / 2.53405; break;
                    }break;

                case "BGN":
                    switch (outputCurrency)
                    {
                        case "USD": total = amount / 1.79549; break;
                        case "EUR": total = amount / 1.95583; break;
                        case "GBP": total = amount / 2.53405; break;
                    }break;

                case "EUR" :
                    switch (outputCurrency)
                    {
                        case "BGN": total = amount * 1.95583; break;
                        case "USD": total = (amount * 1.95583) / 1.79549; break;
                        case "GBP": total = (amount * 1.95583) / 2.53405; break;
                    }break;

                case "GBP":
                    switch (outputCurrency)
                    {
                        case "BGN": total = amount * 2.53405; break;
                        case "USD": total = (amount * 2.53405) / 1.79549; break;
                        case "EUR": total = (amount * 2.53405) / 1.95583; break;
                    }
                    break;
            }
            Console.WriteLine("{0:f2} {1}", total, outputCurrency);
        }
    }
}
