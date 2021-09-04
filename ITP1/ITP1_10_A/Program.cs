using System;

namespace ITP1_10_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            var x1 = double.Parse(line[0]);
            var y1 = double.Parse(line[1]);
            var x2 = double.Parse(line[2]);
            var y2 = double.Parse(line[3]);

            var result = GetDistance(x1, y1, x2, y2);
            Console.WriteLine(result.ToString("F8"));
        }

        static double GetDistance(double x1, double y1, double x2, double y2) {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
    }
}
