using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var firstNumber = number % 10;
            number /= 10;

            var secondNumber = number % 10;
            number /= 10;

            var thirdNumber = number;

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    for (int k = 1; k <= thirdNumber; k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }
        }
    }
}
