using System;

namespace ITP1_8_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = System.Console.ReadLine();
            if (string.IsNullOrEmpty(s)) {
                return;
            }

            var result = String.Empty;
            foreach (var c in s)
            {
                if (Char.IsUpper(c)) {
                    result += Char.ToLower(c);
                } else {
                    result += Char.ToUpper(c);
                }
            }

            Console.WriteLine(result);
        }
    }
}
