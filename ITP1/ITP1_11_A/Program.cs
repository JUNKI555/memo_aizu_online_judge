using System;
using System.Collections.Generic;

namespace ITP1_11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            var line = System.Console.ReadLine().Split(' ');
            for (int i = 0; i < line.Length; i++)
            {
                numberList.Add(int.Parse(line[i]));
            }

            var dice = new Dice(numberList.ToArray());

            var commands = System.Console.ReadLine();
            foreach (var command in commands)
            {
                dice.Operation(command.ToString());
            }

            Console.WriteLine(dice.GetTop().ToString());
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

        public void Operation(string command) {
            switch (command) {
                case "N":
                    ToN();
                    break;
                case "S":
                    ToS();
                    break;
                case "E":
                    ToE();
                    break;
                case "W":
                    ToW();
                    break;
            }
        }

        private void ToN() {
            // 0 1 2 3 4 5
            // 1 5     0 4
            // 5 4     1 0
            var o = numbers[0];
            numbers[0] = numbers[1];
            numbers[1] = numbers[5];
            numbers[5] = numbers[4];
            numbers[4] = o;
        }

        private void ToS() {
            for (int i = 0; i < 3; i++)
            {
                ToN();
            }
        }

        private void ToE() {
            // 0 1 2 3 4 5
            // 3   0 5   2
            // 5   3 2   0
            var o = numbers[0];
            numbers[0] = numbers[3];
            numbers[3] = numbers[5];
            numbers[5] = numbers[2];
            numbers[2] = o;

        }

        private void ToW() {
            for (int i = 0; i < 3; i++)
            {
                ToE();
            }
        }
    }
}
