using System;
using System.Linq;

namespace ITP1_9_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = System.Console.ReadLine();
            var q = int.Parse(System.Console.ReadLine());

            const string print = "print";
            const string reverse = "reverse";
            const string replace = "replace";
            for (int i = 0; i < q; i++)
            {
                var line = System.Console.ReadLine().Split(' ');
                var operation = line[0];

                if (operation == print) {
                    var a = int.Parse(line[1]);
                    var b = int.Parse(line[2]);
                    var operationWordCount = b-a+1;
                    Console.WriteLine(text.Substring(a, operationWordCount));
                    continue;
                }

                if (operation == reverse) {
                    var a = int.Parse(line[1]);
                    var b = int.Parse(line[2]);
                    var operationWordCount = b-a+1;
                    var substr = text.Substring(a, operationWordCount);
                    var charArray = substr.ToCharArray();
                    Array.Reverse(charArray);
                    var target = new string(charArray);
                    text = text.Insert(a, target);
                    text = text.Remove(a + target.Length, operationWordCount);
                    continue;
                }

                if (operation == replace) {
                    var a = int.Parse(line[1]);
                    var b = int.Parse(line[2]);
                    var operationWordCount = b-a+1;
                    var p = line[3];
                    text = text.Insert(a, p);
                    text = text.Remove(a + p.Length, operationWordCount);
                    continue;
                }
            }
        }
    }
}
