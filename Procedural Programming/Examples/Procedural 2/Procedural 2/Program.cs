using System;

namespace Procedural_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");            // This is console
            var name = Console.ReadLine();                      // This is console
            var reversed = ReverseName(name);    
            Console.WriteLine("Reversed Name: " + reversed);    // This is console
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];                  // This is processing
            for (var i = name.Length; i > 0; i--)               // This is processing
                array[name.Length - i] = name[i - 1];           // This is processing

            return new string(array);
        }
    }
}
