using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double laundryPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double stolenMoney = 0;
            double money = 0;
            double totalMoney = 0;
            double toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) 
                {
                    money += i * 10 / 2;
                    stolenMoney++;
                }
                else
                {
                    toys++;
                }
            }
            double sellToys = toys * toysPrice;
            totalMoney = money + sellToys - stolenMoney;
            if (laundryPrice <= totalMoney) 
            {
                Console.WriteLine("Yes! {0:f2}",totalMoney - laundryPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}",laundryPrice - totalMoney);
            }
        }
    }
}
