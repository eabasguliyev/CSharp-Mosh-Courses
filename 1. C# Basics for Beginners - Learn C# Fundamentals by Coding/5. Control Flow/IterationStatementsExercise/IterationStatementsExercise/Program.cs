using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            */
            //int min, max;
            //Console.Write("Min: ");
            //min = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Max: ");
            //max = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Result is {countDivBy3(min, max)}");

            /*
             * Write a program and continuously ask the user to enter a number or "ok" to exit.
             * Calculate the sum of all the previously entered numbers and display it on the console.
             */

            //Console.WriteLine(sum());

            /*
             * Write a program and ask the user to enter a number.
             * Compute the factorial of the number and print it on the console.
             * For example, if the user enters 5,
             * the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */

            //Console.Write("Input: ");
            //var number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{number}! = {factorial(number)}");

            /*
             * Write a program that picks a random number between 1 and 10.
             * Give the user 4 chances to guess the number.
             * If the user guesses the number, display “You won"; otherwise, display “You lost".
             * (To make sure the program is behaving correctly,
             * you can display the secret number on the console first.)
             */

            //guessNumberGame();

            /*
             * Write a program and ask the user to enter a series of numbers separated by comma.
             * Find the maximum of the numbers and display it on the console.
             * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
             */

            //Console.Write("Input: ");
            //var input = Console.ReadLine();
            //Console.WriteLine(getMaxValueOfNumbers(input));
        }
        public static int countDivBy3(int min, int max)
        {
            int counter = 0;
            for (int i = min; i < max; i++)
            {
                if (i % 3 == 0)
                    counter++;
            }

            return counter;
        }

        public static int sum()
        {
            int sum = 0;

            while (true)
            {
                Console.Write("Input: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }

            return sum;
        }

        public static int factorial(int number)
        {
            if (number == 0)
                return 1;
            else if (number < 0)
                return -1;

            int result = 1;

            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }

        public static void guessNumberGame()
        {
            var random = new Random();
            var secretNumber = random.Next(1, 10);

            byte leftChance = 4;

            while (leftChance != 0)
            {
                Console.Write("Guess number: ");
                var guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber == secretNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }

                leftChance--;
                if (leftChance != 0)
                {
                    Console.WriteLine($"Left chance: {leftChance}");
                }
            }

            Console.WriteLine("You lost!");
        }

        public static int getMaxValueOfNumbers(string data)
        {
            var nums = data.Split(',');

            int max = 0;
            foreach (var num in nums)
            {
                var value = Convert.ToInt32(num);
                if (value > max)
                    max = value;
            }
            return max;
        }
    }
}
