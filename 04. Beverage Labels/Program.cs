﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double result = energyContent / 100.0 * volume;
            double resultTwo = volume * sugarContent / 100.0;

            Console.WriteLine("{0}ml {1}:",volume,name);
            Console.WriteLine("{0}kcal, {1}g sugars", result, resultTwo);
        }
    }
}
