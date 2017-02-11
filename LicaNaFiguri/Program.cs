using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicaNaFiguri
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var str1 = double.Parse(Console.ReadLine());

            if (figure == "square")
            {
                Console.WriteLine(Math.Round(str1 * str1, 3));
            }
            else if (figure == "circle")
            {
                Console.WriteLine(Math.Round(Math.PI * (str1 * str1), 3));
            }
            else if (figure == "rectangle")
            {
                var str2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(str1 * str2, 3));
            }
            else if (figure == "triangle")
            {
                var str2 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((str1 * str2)/2, 3));
            }
        }
    }
}
