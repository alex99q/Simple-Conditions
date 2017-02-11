using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var VhodnaEdinica = Console.ReadLine();
            var IzhodnaEdinica = Console.ReadLine();

            if (VhodnaEdinica == "m")
            {
                if (IzhodnaEdinica == "mm")
                {
                    value *= 1000;
                }
                else if (IzhodnaEdinica == "cm")
                {
                    value *= 100;
                }
                else if (IzhodnaEdinica == "mi")
                {
                    value *= 0.000621371192;
                }
                else if (IzhodnaEdinica == "in")
                {
                    value *= 39.3700787;
                }
                else if (IzhodnaEdinica == "km")
                {
                    value *= 0.001;
                }
                else if (IzhodnaEdinica == "ft")
                {
                    value *= 3.2808399;
                }
                else if (IzhodnaEdinica == "yd")
                {
                    value *= 1.0936133;
                }
            }

            if (VhodnaEdinica == "mm")
            {
                if (IzhodnaEdinica == "m")
                {
                    value = value / 1000;
                }
                else if (IzhodnaEdinica == "cm")
                {
                    value = (value / 1000) * 100;
                }
                else if (IzhodnaEdinica == "mi")
                {
                    value = (value / 1000) * 0.000621371192;
                }
                else if (IzhodnaEdinica == "in")
                {
                    value = (value / 1000) * 39.3700787;
                }
                else if (IzhodnaEdinica == "km")
                {
                    value = (value / 1000) * 0.001;
                }
                else if (IzhodnaEdinica == "ft")
                {
                    value = (value / 1000) * 3.2808399;
                }
                else if (IzhodnaEdinica == "yd")
                {
                    value = (value / 1000) * 1.0936133;
                }
            }

            if (VhodnaEdinica == "cm")
            {
                if (IzhodnaEdinica == "m")
                {
                    value = value / 100;
                }
                else if (IzhodnaEdinica == "mm")
                {
                    value = (value / 100) * 1000;
                }
                else if (IzhodnaEdinica == "mi")
                {
                    value = (value / 100) * 0.000621371192;
                }
                else if (IzhodnaEdinica == "in")
                {
                    value = (value / 100) * 39.3700787;
                }
                else if (IzhodnaEdinica == "km")
                {
                    value = (value / 100) * 0.001;
                }
                else if (IzhodnaEdinica == "ft")
                {
                    value = (value / 100) * 3.2808399;
                }
                else if (IzhodnaEdinica == "yd")
                {
                    value = (value / 100) * 1.0936133;
                }
            }

            if (VhodnaEdinica == "mi")
            {
                if (IzhodnaEdinica == "m")
                {
                    value = value / 0.000621371192;
                }
                else if (IzhodnaEdinica == "mm")
                {
                    value = (value / 0.000621371192) * 1000;
                }
                else if (IzhodnaEdinica == "cm")
                {
                    value = (value / 0.000621371192) * 100;
                }
                else if (IzhodnaEdinica == "in")
                {
                    value = (value / 0.000621371192) * 39.3700787;
                }
                else if (IzhodnaEdinica == "km")
                {
                    value = (value / 0.000621371192) * 0.001;
                }
                else if (IzhodnaEdinica == "ft")
                {
                    value = (value / 0.000621371192) * 3.2808399;
                }
                else if (IzhodnaEdinica == "yd")
                {
                    value = (value / 0.000621371192) * 1.0936133;
                }
            }

            if (VhodnaEdinica == "in")
            {
                if (IzhodnaEdinica == "m")
                {
                    value = value / 39.3700787;
                }
                else if (IzhodnaEdinica == "mm")
                {
                    value = (value / 39.3700787) * 1000;
                }
                else if (IzhodnaEdinica == "cm")
                {
                    value = (value / 39.3700787) * 100;
                }
                else if (IzhodnaEdinica == "mi")
                {
                    value = (value / 39.3700787) * 0.000621371192;
                }
                else if (IzhodnaEdinica == "km")
                {
                    value = (value / 39.3700787) * 0.001;
                }
                else if (IzhodnaEdinica == "ft")
                {
                    value = (value / 39.3700787) * 3.2808399;
                }
                else if (IzhodnaEdinica == "yd")
                {
                    value = (value / 39.3700787) * 1.0936133;
                }
            }

            if (VhodnaEdinica == "km")
            {
                if (IzhodnaEdinica == "m")
                {
                    value = value / 0.001;
                }
                else if (IzhodnaEdinica == "mm")
                {
                    value = (value / 0.001) * 1000;
                }
                else if (IzhodnaEdinica == "cm")
                {
                    value = (value / 0.001) * 100;
                }
                else if (IzhodnaEdinica == "mi")
                {
                    value = (value / 0.001) * 0.000621371192;
                }
                else if (IzhodnaEdinica == "in")
                {
                    value = (value / 0.001) * 39.3700787;
                }
                else if (IzhodnaEdinica == "ft")
                {
                    value = (value / 0.001) * 3.2808399;
                }
                else if (IzhodnaEdinica == "yd")
                {
                    value = (value / 0.001) * 1.0936133;
                }
            }

            if (VhodnaEdinica == "ft")
            {
                if (IzhodnaEdinica == "m")
                {
                    value = value / 3.2808399;
                }
                else if (IzhodnaEdinica == "mm")
                {
                    value = (value / 3.2808399) * 1000;
                }
                else if (IzhodnaEdinica == "cm")
                {
                    value = (value / 3.2808399) * 100;
                }
                else if (IzhodnaEdinica == "mi")
                {
                    value = (value / 3.2808399) * 0.000621371192;
                }
                else if (IzhodnaEdinica == "in")
                {
                    value = (value / 3.2808399) * 39.3700787;
                }
                else if (IzhodnaEdinica == "km")
                {
                    value = (value / 3.2808399) * 0.001;
                }
                else if (IzhodnaEdinica == "yd")
                {
                    value = (value / 3.2808399) * 1.0936133;
                }
            }

            if (VhodnaEdinica == "yd")
            {
                if (IzhodnaEdinica == "m")
                {
                    value = value / 1.0936133;
                }
                else if (IzhodnaEdinica == "mm")
                {
                    value = (value / 1.0936133) * 1000;
                }
                else if (IzhodnaEdinica == "cm")
                {
                    value = (value / 1.0936133) * 100;
                }
                else if (IzhodnaEdinica == "mi")
                {
                    value = (value / 1.0936133) * 0.000621371192;
                }
                else if (IzhodnaEdinica == "in")
                {
                    value = (value / 1.0936133) * 39.3700787;
                }
                else if (IzhodnaEdinica == "km")
                {
                    value = (value / 1.0936133) * 0.001;
                }
                else if (IzhodnaEdinica == "ft")
                {
                    value = (value / 1.0936133) * 3.2808399;
                }
            }

            Console.WriteLine(value);

        }
    }
}
