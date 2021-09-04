using System;

namespace ITP1_1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]);
            var b = int.Parse(line[1]);
            var area = a*b;
            var perimeter = a+a+b+b;

            Console.WriteLine($"{area} {perimeter}");
        }
    }
}
