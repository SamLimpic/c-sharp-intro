using System;

namespace c_sharp_intro.Models
{
    public class Game
    {
        private int Number { get; set; }
        public int Guesses { get; private set; }

        public bool Guess(int num)
        {
            Guesses++;
            string tries = Guesses < 2 ? "try" : "tries";
            string times = Guesses < 2 ? "time" : "times";

            if (num == Number)
            {
                Console.WriteLine($"You Got It!  And it only took you {Guesses} {tries}...");
                return true;
            }
            else if (num > Number)
            {
                Console.WriteLine($"Your guess is too high!  You've been wrong {Guesses} {times}...");
            }
            else
            {
                Console.WriteLine($"Your guess is too low!  You've been wrong {Guesses} {times}...");
            }
            return false;
        }

        public Game()
        {
            Random rnd = new Random();
            // NOTE Random Number Generator
            Number = rnd.Next(1, 101);
            // Console.WriteLine(Number);
            Guesses = 0;
        }
    }
}