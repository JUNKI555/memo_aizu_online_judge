using System;
using System.Collections.Generic;

namespace ITP1_11_B
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var numberList = new List<int>();
            var qLine = System.Console.ReadLine().Split(' ');
            for (int i = 0; i < qLine.Length; i++)
            {
                numberList.Add(int.Parse(qLine[i]));
            }

            var n = int.Parse(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = System.Console.ReadLine().Split(' ');
                var wantTop = int.Parse(line[0]);
                var wantFront = int.Parse(line[1]);
                var dice = new Dice(numberList.ToArray());

                if ((wantTop == numberList[2])||(wantTop == numberList[3])) {
                    dice.ToE();
                    if (dice.GetTop() == wantTop) {
                        while (dice.GetFront() != wantFront) {
                            dice.ToZ();
                        }
                        Console.WriteLine(dice.GetSideE().ToString());
                        continue;
                    }
                    dice.ToE();
                    dice.ToE();
                    while (dice.GetFront() != wantFront) {
                        dice.ToZ();
                    }
                    Console.WriteLine(dice.GetSideE().ToString());
                    continue;
                }

                if (dice.GetTop() == wantTop) {
                    while (dice.GetFront() != wantFront) {
                        dice.ToZ();
                    }
                    Console.WriteLine(dice.GetSideE().ToString());
                    continue;
                }

                dice.ToN();
                if (dice.GetTop() == wantTop) {
                    while (dice.GetFront() != wantFront) {
                        dice.ToZ();
                    }
                    Console.WriteLine(dice.GetSideE().ToString());
                    continue;
                }

                dice.ToN();
                if (dice.GetTop() == wantTop) {
                    while (dice.GetFront() != wantFront) {
                        dice.ToZ();
                    }
                    Console.WriteLine(dice.GetSideE().ToString());
                    continue;
                }

                dice.ToN();
                if (dice.GetTop() == wantTop) {
                    while (dice.GetFront() != wantFront) {
                        dice.ToZ();
                    }
                    Console.WriteLine(dice.GetSideE().ToString());
                    continue;
                }
            }

            Console.Out.Flush();
        }
    }

    public class Dice {

        private int[] numbers;

        public Dice(int[] numbers) {
            this.numbers = numbers;
        }

        public int GetTop() {
            return numbers[0];
        }

        public int GetFront() {
            return numbers[1];
        }

        public int GetSideE() {
            return numbers[2];
        }

        public void ToN() {
            var o = numbers[0];
            numbers[0] = numbers[1];
            numbers[1] = numbers[5];
            numbers[5] = numbers[4];
            numbers[4] = o;
        }

        public void ToS() {
            for (int i = 0; i < 3; i++)
            {
                ToN();
            }
        }

        public void ToE() {
            var o = numbers[0];
            numbers[0] = numbers[3];
            numbers[3] = numbers[5];
            numbers[5] = numbers[2];
            numbers[2] = o;

        }

        public void ToW() {
            for (int i = 0; i < 3; i++)
            {
                ToE();
            }
        }

        public void ToZ() {
            // 0 1 2 3 4 5
            //   3 1 4 2  
            //   4 3 2 1  
            var o = numbers[1];
            numbers[1] = numbers[3];
            numbers[3] = numbers[4];
            numbers[4] = numbers[2];
            numbers[2] = o;
        }
    }
}
