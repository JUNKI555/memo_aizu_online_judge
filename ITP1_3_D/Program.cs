using System;

namespace ITP1_3_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            var a = int.Parse(line[0]);
            var b = int.Parse(line[1]);
            var c = int.Parse(line[2]);

            var divisorCout = 0;
            for (var i = a; i <= b; i++) {
                if ((c % i) == 0) {
                    divisorCout++;
                }
            }

            Console.WriteLine($"{divisorCout}");
        }
    }
}
