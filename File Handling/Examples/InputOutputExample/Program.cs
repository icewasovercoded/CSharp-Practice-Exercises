using System;
using System.IO;

namespace InputOutputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"h:\Downloads\Example4.mp4";
            File.Copy(@"h:\Downloads\TEMP\3 quid.jpg", @"h:\Downloads\3 quid.jpg", true);

            if (File.Exists(path))
            {
                Console.WriteLine("Good to go");
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            
            if (fileInfo.Exists)
            {
                Console.WriteLine(fileInfo);
            }
            fileInfo.CopyTo(@"h:\Downloads\Example.mp4");
        }
    }
}
