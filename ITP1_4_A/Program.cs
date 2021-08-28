using System;

namespace ITP1_4_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]);
            var b = int.Parse(line[1]);

            Console.WriteLine($"{a/b} {a%b} {a/(double)b:F8}");
        }
    }
}
