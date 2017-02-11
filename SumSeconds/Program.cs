using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var susteztel1 = int.Parse(Console.ReadLine());
            var susteztel2 = int.Parse(Console.ReadLine());
            var susteztel3 = int.Parse(Console.ReadLine());
            int sustezteli = susteztel1 + susteztel2 + susteztel3;

            if (sustezteli > 0 && sustezteli < 60)
            {
                if (sustezteli < 10)
                {
                    Console.WriteLine("0:0" + sustezteli);
                }
                else
                {
                    Console.WriteLine("0:" + sustezteli);
                }
            }

            if (sustezteli > 59 && sustezteli < 120)
            {
                if (sustezteli - 60 < 10)
                {
                    Console.WriteLine("1:0" + (sustezteli - 60));
                }
                else
                {
                    Console.WriteLine("1:" + (sustezteli - 60));
                }
            }

            if (sustezteli > 119 && sustezteli < 180)
            {
                if (sustezteli - 120 < 10)
                {
                    Console.WriteLine("2:0" + (sustezteli - 120));
                }
                else
                {
                    Console.WriteLine("2:" + (sustezteli - 120));
                }
            }

        }
    }
}
