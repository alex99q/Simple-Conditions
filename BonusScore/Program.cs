using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            double bonus_score = 0;
            if (input <= 100)
            {
                bonus_score = bonus_score + 5;
            }
            else if (input > 100 && input <= 1000)
            {
                bonus_score = input * 0.2;
            }
            else if (input > 1000)
            {
                bonus_score = input * 0.1;
            }
            if (input % 2 == 0)
            {
                bonus_score = bonus_score + 1;
            }
            else if (input % 5 == 0)
            {
                bonus_score = bonus_score + 2;      
            }
            Console.WriteLine(bonus_score);
            Console.WriteLine(input + bonus_score);
        }
    }
}
