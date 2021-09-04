using System;

namespace ITP1_1_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var seconds = int.Parse(Console.ReadLine());
            var timeSpan = new TimeSpan(0, 0, seconds);
            Console.WriteLine(timeSpan.ToString(@"h\:m\:s"));
        }
    }
}
