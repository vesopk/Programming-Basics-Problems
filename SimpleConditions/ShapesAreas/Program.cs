using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape = Console.ReadLine();
            if (shape == "square")
            {
                var side = double.Parse(Console.ReadLine());
                var area = side * side;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (shape == "rectangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                var area = side1 * side2;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (shape == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                var area = Math.PI * radius * radius;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (shape == "triangle") 
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = (side * height) / 2;
                Console.WriteLine(Math.Round(area,3));
            }
        }
    }
}
