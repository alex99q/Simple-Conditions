using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            if (hour >= 0 && hour < 24 && min >= 0 && min < 60)
            {
                min = min + 15;
                if(min > 59)
                {
                    hour++;
                    min = min - 60;
                }
                if(hour == 24)
                {
                    hour = 0;
                }
                if(min < 10)
                {
                    Console.WriteLine(hour + ":0" + min);
                }
                else
                {
                    Console.WriteLine(hour + ":" + min);
                }
            }
        }
    }
}
