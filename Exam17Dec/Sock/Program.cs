using System;

namespace Sock
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var rowLen = n * 2;

            // Top Part
            Console.WriteLine($"|{new string('-', rowLen)}|");
            Console.WriteLine($"|{new string('*', rowLen)}|");
            Console.WriteLine($"|{new string('-', rowLen)}|");

            // Middle Part

            var middlePartLoopLegacy = (n * 2) - 3;
            var middlePartLoopCount = ((n * 2) - 3) / 2 + 1;
            var secondMiddlePartLoop = middlePartLoopLegacy - middlePartLoopCount;

            var symbolCount = 2;

            for (int i = 0; i < middlePartLoopCount; i++)
            {
                Console.WriteLine($"|{new string('-', (rowLen - symbolCount) / 2)}{new string('~', symbolCount)}{new string('-', (rowLen - symbolCount) / 2)}|");
                symbolCount += 2;
            }
            symbolCount -= 4;

            for (int i = 0; i < secondMiddlePartLoop; i++)
            {
                Console.WriteLine($"|{new string('-', (rowLen - symbolCount) / 2)}{new string('~', symbolCount)}{new string('-', (rowLen - symbolCount) / 2)}|");
                symbolCount -= 2;
            }

            //Bottom Part

            var bottomPartLoopCount = ((3 * n) + 3) - 3 - middlePartLoopCount - secondMiddlePartLoop;
            var cristmasLine = int.MaxValue;

            if (bottomPartLoopCount % 2 == 0)
            {
                for (int i = 0; i < bottomPartLoopCount; i++)
                {
                    if (i == bottomPartLoopCount - 1)
                    {
                        Console.WriteLine($@"{new string('-', i)}\{new string('_', n * 2 + 1)})");
                    }
                    else if (i + 1 == (bottomPartLoopCount / 2) - 1)
                    {
                        Console.WriteLine($@"{new string('-', i)}\{new string('.', (n * 2 + 1 - 5) / 2)}MERRY{new string('.', (n * 2 + 1 - 5) / 2)}\");
                        cristmasLine = i;
                    }
                    else if (i == cristmasLine + 2)
                    {
                        Console.WriteLine($@"{new string('-', i)}\{new string('.', (n * 2 + 1 - 5) / 2)}X-MAS{new string('.', (n * 2 + 1 - 5) / 2)}\");
                    }
                    else
                    {
                        Console.WriteLine($@"{new string('-', i)}\{new string('.', n * 2 + 1)}\");
                    }
                }
            }
            else if (bottomPartLoopCount % 2 != 0)
            {
                for (int i = 0; i < bottomPartLoopCount; i++)
                {
                    if (i == bottomPartLoopCount - 1)
                    {
                        Console.WriteLine($@"{new string('-', i)}\{new string('_', n * 2 + 1)})");
                    }
                    else if (i + 1 == (bottomPartLoopCount / 2))
                    {
                        Console.WriteLine($@"{new string('-', i)}\{new string('.', (n * 2 + 1 - 5) / 2)}MERRY{new string('.', (n * 2 + 1 - 5) / 2)}\");
                        cristmasLine = i;
                    }
                    else if (i == cristmasLine + 2)
                    {
                        Console.WriteLine($@"{new string('-', i)}\{new string('.', (n * 2 + 1 - 5) / 2)}X-MAS{new string('.', (n * 2 + 1 - 5) / 2)}\");
                    }
                    else
                    {
                        Console.WriteLine($@"{new string('-', i)}\{new string('.', n * 2 + 1)}\");
                    }
                }
            }
        }
    }
}
