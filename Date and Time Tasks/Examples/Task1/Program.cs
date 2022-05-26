using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2022, 4, 28);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minutes: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
