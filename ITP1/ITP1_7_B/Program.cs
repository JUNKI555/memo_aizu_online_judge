using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP1_7_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            const int blankNumber = 0;
            var continueFlag = true;
            while (continueFlag) {
                var line = System.Console.ReadLine().Split(' ');
                var n = int.Parse(line[0]);
                var x = int.Parse(line[1]);

                if ((n == blankNumber)&&(x == blankNumber)) {
                    continueFlag = false;
                    continue;
                }

                if (x < 6) {
                    Console.WriteLine("0");
                    continue;
                }

                var combinationCount = 0;
                var ignoreList = new List<string>();
                for (var i = 1; i <= n; i++) {
                    for (var j = 1; j <= n; j++) {
                        if (i == j) {
                            continue;
                        }

                        var kCalc = x - (i + j);
                        if ((kCalc < 3)||(kCalc > n)||(kCalc == i)||(kCalc == j)) {
                            continue;
                        }

                        var numberList = new List<int>();
                        numberList.Add(i);
                        numberList.Add(j);
                        numberList.Add(kCalc);
                        numberList.Sort();

                        var stringNumberList = String.Join(",", numberList);
                        if (ignoreList.Contains(stringNumberList)) {
                            continue;
                        }

                        ignoreList.Add(stringNumberList);
                        combinationCount++;
                    }
                }

                Console.WriteLine(combinationCount.ToString());
            }
            Console.Out.Flush();
        }
    }
}
