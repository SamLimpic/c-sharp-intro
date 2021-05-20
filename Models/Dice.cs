using System;
using System.Threading;

namespace c_sharp_intro.Models
{
    public class Dice
    {

        public int sides { get; set; }

        public void Roll(int sides)
        {
            int num1;
            int num2;
            int sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Thread.Sleep(250);
                    Console.Write('.');
                };
                num1 = rnd.Next(1, sides + 1);
                num2 = rnd.Next(1, sides + 1);
                if (num1 == num2)
                {
                    Console.WriteLine("Doubles score 0 points... Sad...");
                }
                else
                {
                    sum += (num1 + num2);
                    Console.WriteLine($"You scored {num1 + num2} points!");
                }
                Console.WriteLine($"Your total score is {sum}!");
            }
        }
    }
}