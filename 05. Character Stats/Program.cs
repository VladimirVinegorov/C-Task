using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);

            var sumOne = maximumEnergy - currentEnergy;
            var sumTwo = maximumHealth - currentHealth;
          
            Console.Write("Health: |");
            for (int i = 0; i < maximumHealth - sumTwo; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < maximumHealth - currentHealth; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");

            Console.Write("Energy: |");
            for (int i = 0; i < maximumEnergy - sumOne; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < maximumEnergy - currentEnergy; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }
    }
}
