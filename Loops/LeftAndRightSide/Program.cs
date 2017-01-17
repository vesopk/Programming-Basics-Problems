using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSide
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int sum = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                sum = int.Parse(Console.ReadLine());
                leftSum += sum;
            }
            for (int i = 0; i < numberOfNumbers; i++)
            {
                sum = int.Parse(Console.ReadLine());
                rightSum += sum;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else if (leftSum != rightSum) 
            {
                Console.WriteLine("No, diff = {0}" , Math.Abs(leftSum - rightSum));
            }
            
        }
    }
}
