using System;

namespace Procedural
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");            // This is console
            var name = Console.ReadLine();                      // This is console

            var array = new char[name.Length];                  // This is processing
            for (var i = name.Length; i > 0; i--)               // This is processing
                array[name.Length - i] = name[i - 1];           // This is processing

            var reversed = new string(array);                   // This is processing
            Console.WriteLine("Reversed Name: " + reversed);    // This is console
        }
    }
}
