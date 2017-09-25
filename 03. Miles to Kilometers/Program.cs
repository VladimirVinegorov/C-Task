using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputMiles = decimal.Parse(Console.ReadLine());

            decimal oneMiles = (decimal)1.60934;

            var sum = inputMiles * oneMiles;
            Console.WriteLine("{0:F2}",sum);
        }
    }
}
