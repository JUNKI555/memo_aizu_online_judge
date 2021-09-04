using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_9_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var question = System.Console.ReadLine().ToLower();

            var wordList = new List<string>();
            var continueFlag = true;
            while (continueFlag) {
                var line = System.Console.ReadLine();
                if (line == "END_OF_TEXT") {
                    continueFlag = false;
                    continue;
                }

                var wordArray = line.Split(' ');
                foreach (var word in wordArray)
                {
                    wordList.Add(word.ToLower());
                }
            }

            var count = wordList.Count(value => value == question);
            Console.WriteLine(count.ToString());

            Console.Out.Flush();
        }
    }
}
