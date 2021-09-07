using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP2_1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var q = int.Parse(Console.ReadLine());
            var list = new LinkedList<int>();
            LinkedListNode<int> cur = null;
            int firstOrLast = -1;   // first:-1, 0, last:1
            for (int i = 0; i < q; i++)
            {
                var line = System.Console.ReadLine();

                // erase
                if (line.StartsWith("2")) {
                    var tmp = cur.Next;
                    list.Remove(cur);
                    cur = tmp;
                    if (cur == null) {
                        firstOrLast = 1;
                    }
                    // Console.WriteLine($"after erase: {string.Join(",", list)}");
                    // Console.WriteLine($"after erase: firstOrLast: {firstOrLast}");
                    continue;
                }

                var splitLine = line.Split(' ');
                var command = splitLine[0];
                var xd = int.Parse(splitLine[1]);

                // insert
                if (command == "0") {
                    if (cur == null) {
                        if (firstOrLast == -1) {
                            cur = list.AddFirst(xd);
                            firstOrLast = 0;
                        } else {
                            cur = list.AddLast(xd);
                            firstOrLast = 0;
                        }
                    } else {
                        cur = list.AddBefore(cur, xd);
                        firstOrLast = 0;
                    }

                    // Console.WriteLine($"after insert: {string.Join(",", list)}");
                    // Console.WriteLine($"after insert: firstOrLast: {firstOrLast}");
                    continue;
                }

                // move
                if (xd > 0) {
                    // Next
                    for (int j = 0; j < xd; j++)
                    {
                        if (cur == null) {
                            if (firstOrLast == -1) {
                                cur = list.First;
                                firstOrLast = 0;
                                continue;
                            } else {
                                // これ以上何もできない
                                break;
                            }
                        }

                        cur = cur.Next;

                        if (cur == null) {
                            firstOrLast = 1;
                            break;
                        } else {
                            firstOrLast = 0;
                        }
                    }
                } else {
                    // Previous
                    for (int j = 0; j < (xd * -1); j++)
                    {
                        if (cur == null) {
                            if (firstOrLast == -1) {
                                // これ以上何もできない
                                break;
                            } else {
                                // last
                                cur = list.Last;
                                firstOrLast = 0;
                                continue;
                            }
                        }

                        cur = cur.Previous;

                        if (cur == null) {
                            firstOrLast = -1;
                            break;
                        } else {
                            firstOrLast = 0;
                        }
                    }
                }
                // Console.WriteLine($"after move: firstOrLast: {firstOrLast}");
            }

            // output
            var array = new int[list.Count];
            list.CopyTo(array, 0);
            foreach (var num in array)
            {
                Console.WriteLine(num.ToString());
            }

            Console.Out.Flush();
        }
    }
}
