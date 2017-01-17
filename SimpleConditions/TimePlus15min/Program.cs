using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15min
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var bonusTime = 15;
            var exitHours = 0;
            var exitMinutes = 0;
            if (time2 + bonusTime <= 59)
            {
                exitHours = time1;
                exitMinutes = time2 + bonusTime;
                Console.WriteLine("{0}:{1:00}",exitHours,exitMinutes);
            }
            else if (time2 + bonusTime > 59)
            {
                exitHours = time1 + 1;
                exitMinutes = (time2 + bonusTime) - 60;

                if (exitHours>23)
                {
                    time1 = 0;
                    exitHours = time1;
                    exitMinutes = (time2 + bonusTime) - 60;
                    Console.WriteLine("{0}:{1:00}", exitHours, exitMinutes);
                }else
                {
                    exitHours = time1 + 1;
                    exitMinutes = (time2 + bonusTime) - 60;
                    Console.WriteLine("{0}:{1:00}", exitHours, exitMinutes);
                }
                
                
            }
        }
    }
}
