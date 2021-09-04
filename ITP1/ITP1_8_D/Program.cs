using System;

namespace ITP1_8_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = System.Console.ReadLine();
            var p = System.Console.ReadLine();

            var circleString = s + s;
            if (circleString.Contains(p)) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }
}
