using System;
using System.Collections.Generic;

namespace Procedural_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or 'Quit' to quit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == 'quit')
                    break;

                numbers.Add(Convert.ToInt32(input));

            }

            var uniques = 
        }
    }
}
