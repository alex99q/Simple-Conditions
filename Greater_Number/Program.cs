﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if (num1 >= num2)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine(num2);
            }
        }
    }
}
