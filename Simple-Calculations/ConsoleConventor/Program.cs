using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConventor
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            if (value1 == "USD" && value2 == "BGN")
            {
                double USDtoBGN = money * 1.79549;
                double round = Math.Round(USDtoBGN, 2);
                Console.WriteLine("{0} BGN", round);
            }
            else if (value1 == "USD" && value2 == "EUR")
            {
                double USDtoEUR = (money * 1.79549) / 1.95583;
                double round = Math.Round(USDtoEUR, 2);
                Console.WriteLine("{0} EUR", round);
            }
            else if (value1 == "USD" && value2 == "GBP")
            {
                double USDtoGBP = (money * 1.79549) / 2.53405;
                double round = Math.Round(USDtoGBP, 2);
                Console.WriteLine("{0} GBP", round);
            }
            else if (value1 == "BGN" && value2 == "EUR")
            {
                double BGNtoEUR = money / 1.95583;
                double round = Math.Round(BGNtoEUR, 2);
                Console.WriteLine("{0} EUR", round);
            }
            else if (value1 == "BGN" && value2 == "GBP")
            {
                double BGNtoGBP = money / 2.53405;
                double round = Math.Round(BGNtoGBP, 2);
                Console.WriteLine("{0} GBP", round);
            }
            else if (value1 == "BGN" && value2 == "USD")
            {
                double BGNtoUSD = money / 1.79549;
                double round = Math.Round(BGNtoUSD, 2);
                Console.WriteLine("{0} USD", round);
            }
            else if(value1 == "EUR" && value2 == "GBP")
            {
                double EURtoGBP = (money * 1.95583) / 2.53405;
                double round = Math.Round(EURtoGBP, 2);
                Console.WriteLine("{0} GBP", round);
            }
            else if (value1 == "EUR" && value2 == "BGN")
            {
                double EURtoBGN = money * 1.95583;
                double round = Math.Round(EURtoBGN, 2);
                Console.WriteLine("{0} BGN", round);
            }
            else if (value1 == "EUR" && value2 == "USD")
            {
                double EURtoUSD = (money* 1.95583)/ 1.79549;
                double round = Math.Round(EURtoUSD, 2);
                Console.WriteLine("{0} USD", round);
            }
            else if (value1 == "GBP" && value2 == "USD")
            {
                double GBPtoUSD = (money * 2.53405) / 1.79549;
                double round = Math.Round(GBPtoUSD, 2);
                Console.WriteLine("{0} USD", round);
            }
            else if (value1 == "GBP" && value2 == "EUR")
            {
                double GBPtoEUR = (money * 2.53405) / 1.95583;
                double round = Math.Round(GBPtoEUR, 2);
                Console.WriteLine("{0} EUR", round);
            }
            else if (value1 == "GBP" && value2 == "BGN")
            {
                double GBPtoBGN = money * 2.53405;
                double round = Math.Round(GBPtoBGN, 2);
                Console.WriteLine("{0} BGN", round);
            }
            else
            {
                Console.WriteLine("Incorrect currency !");
            }
        }
    }
}
