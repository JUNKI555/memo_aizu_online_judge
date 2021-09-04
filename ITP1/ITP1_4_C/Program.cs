using System;

namespace ITP1_4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var endFlag = true;
            while (endFlag) {
                var line = System.Console.ReadLine().Split(' ');
                var a = int.Parse(line[0]);
                var op = line[1];
                var b = int.Parse(line[2]);

                if (op == "?") {
                    endFlag = false;
                } else {
                    var answer = 0;
                    switch (op) {
                        case "+":
                            answer = a + b;
                            break;
                        case "-":
                            answer = a - b;
                            break;
                        case "*":
                            answer = a * b;
                            break;
                        case "/":
                            answer = (int)(a / b);
                            break;
                    }
                    Console.WriteLine($"{answer}");
                }
            }

            Console.Out.Flush();
        }
    }
}
