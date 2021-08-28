using System;

namespace ITP1_4_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var circleArea = r * r * Math.PI;
            var circlePerimeter = 2 * r * Math.PI;

            Console.WriteLine($"{circleArea:F6} {circlePerimeter:F6}");
        }
    }
}
