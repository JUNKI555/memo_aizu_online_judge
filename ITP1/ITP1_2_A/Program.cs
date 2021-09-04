using System;

namespace ITP1_2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]);
            var b = int.Parse(line[1]);

            if (a < b) {
                Console.WriteLine("a < b");
                return;
            }

            if (a > b) {
                Console.WriteLine("a > b");
                return;
            }

            Console.WriteLine("a == b");
        }
    }
}
