using System;

namespace ITP1_2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]);
            var b = int.Parse(line[1]);
            var c = int.Parse(line[2]);

            if ((a < b)&&(b < c)) {
                Console.WriteLine("Yes");
                return;
            }

            Console.WriteLine("No");
        }
    }
}
