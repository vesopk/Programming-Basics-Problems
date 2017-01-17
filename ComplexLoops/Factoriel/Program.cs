using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factoriel
{
    
    class Program
    {
        private decimal num;
        public static decimal factoriel(decimal num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * factoriel(num - 1);
            }
        }
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal result = factoriel(n);
            Console.WriteLine(result);
        }
    }
}
