using System;
using System.Collections.Generic;
using System.Linq;

namespace ITP2_1_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var q = int.Parse(Console.ReadLine());

            var list = new int[q*2];
            var head = q;
            var ass = q+1;
            for (int i = 0; i < q; i++)
            {
                var line = System.Console.ReadLine().Split(' ');
                var command = line[0];
                var dp = int.Parse(line[1]);

                // push
                if (command == "0") {
                    var x = int.Parse(line[2]);

                    if (dp == 0) {
                        list[head] = x;
                        head--;
                    } else {
                        list[ass] = x;
                        ass++;
                    }

                    continue;
                }

                // pop
                if (command == "2") {
                    if (dp == 0) {
                        head++;
                    } else {
                        ass--;
                    }

                    continue;
                }

                // randomAccess
                Console.WriteLine(list[head+1+dp].ToString());
                // Console.WriteLine($"answer: {list[head+1+dp]}");
            }

            Console.Out.Flush();
        }
    }
}


// TLE : LinkedList
// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace ITP2_1_B
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
//             Console.SetOut(sw);

//             var q = int.Parse(Console.ReadLine());

//             var list = new LinkedList<int>();
//             for (int i = 0; i < q; i++)
//             {
//                 var line = System.Console.ReadLine().Split(' ');
//                 var command = line[0];
//                 var dp = int.Parse(line[1]);

//                 // push
//                 if (command == "0") {
//                     var x = int.Parse(line[2]);

//                     if (dp == 0) {
//                         list.AddFirst(x);
//                     } else {
//                         list.AddLast(x);
//                     }

//                     continue;
//                 }

//                 // pop
//                 if (command == "2") {
//                     if (dp == 0) {
//                         list.RemoveFirst();
//                     } else {
//                         list.RemoveLast();
//                     }

//                     continue;
//                 }

//                 // randomAccess
//                 Console.WriteLine(list.Skip(dp).First().ToString());
//             }

//             Console.Out.Flush();
//         }
//     }
// }
