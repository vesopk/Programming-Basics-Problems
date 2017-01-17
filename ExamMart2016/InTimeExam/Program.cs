using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTimeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());
            var examTime = (examHour * 60) + examMinute;
            var arrivalTime = (arrivalHour * 60) + arrivalMinute;
            var studentDelay = examTime - arrivalTime;
            if (studentDelay < -30)
            {
                Console.WriteLine("Early");
            }
            else if (studentDelay <= 0) 
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }
            if (studentDelay != 0 )
            {
                var hours = Math.Abs(studentDelay / 60);
                var minutes = Math.Abs(studentDelay % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                        Console.Write(hours + ":0" + minutes + " hours");
                    else
                        Console.Write(hours + ":" + minutes + " hours");
                }
                else
                    Console.Write(minutes + " minutes");
                if (studentDelay < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");
            }
        }

        }
    }

