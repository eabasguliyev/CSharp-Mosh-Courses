using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ArrayAndListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            Depending on the number of names provided, display a message based on the above pattern.
             */

            //facebookSimulation();

            /*
             * Write a program and ask the user to enter their name.
             * Use an array to reverse the name and then store the result in a new string.
             * Display the reversed name on the console.
             */

            //reverseName();

            /*
             * Write a program and ask the user to enter 5 numbers.
             * If a number has been previously entered, display an error message and ask the user to re-try.
             * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
             */
            //fiveUniqueNumber();

            /*
             * Write a program and ask the user to continuously enter a number or type "Quit" to exit.
             * The list of numbers may include duplicates.
             * Display the unique numbers that the user has entered.
             */
            //uniqueNumbers();

            /*
             * Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
             * If the list is empty or includes less than 5 numbers,
             * display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
             */
            threeSmallestNumber();
        }

        public static void facebookSimulation()
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input)) // isNullOrWhiteSpace()
                    break;

                names.Add(input);
            }

            var countOfNames = names.Count;

            if (countOfNames == 0)
                return;

            if(countOfNames == 1)
                Console.WriteLine($"{names[0]} likes your post");
            else if(countOfNames == 2)
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            else
                Console.WriteLine($"{names[0]} and {names[1]} and {countOfNames - 2} others like your post");
        }

        public static void reverseName()
        {
            Console.Write("Enter your name: ");
            var input = Console.ReadLine();

            var lengthOfName = input.Length;
            var array = new char[lengthOfName];

            for (int i = lengthOfName; i > 0; i--)
            {
                array[i - 1] = input[lengthOfName - i];
            }

            var reverseName = string.Join("", array);
            // var reverseName = new string(array);
            Console.WriteLine(reverseName);
        }

        public static void fiveUniqueNumber()
        {
            var uniqueNumbers = new List<int>();

            while (true)
            {
                Console.Write("Enter unique number: ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (uniqueNumbers.Contains(input))
                {
                    Console.WriteLine("Re-try");
                    continue;
                }

                uniqueNumbers.Add(input);
                if (uniqueNumbers.Count == 5)
                    break;
            }

            uniqueNumbers.Sort();
            foreach (var number in uniqueNumbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }

        public static void uniqueNumbers()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Number: ");
                var input = Console.ReadLine().ToLower();

                if (input.Equals("quit"))
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();

            for (int i = 0, LENGTH = numbers.Count; i < LENGTH; i++)
            {
                if(!uniques.Contains(numbers[i]))
                    uniques.Add(numbers[i]);
            }
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    for (int j = i + 1; j < numbers.Count; j++)
            //    {
            //        if(numbers[i] == numbers[j])
            //            numbers.RemoveAt(j);
            //    }
            //}

            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");   
            }
            Console.WriteLine();
        }

        public static void threeSmallestNumber()
        {
            var numbers = new List<int>();
            string[] array;
            while (true)
            {
                Console.Write("Type comma separated numbers: ");

                var input = Console.ReadLine();

                array = input.Split(',', ' ');

                if (array.Length >= 5)
                    break;
                Console.WriteLine("Invalid list");
            }

            foreach (var character in array)
                numbers.Add(Convert.ToInt32(character));

            var smallest = new List<int>();

            while (smallest.Count < 3)
            {
                var min = numbers.Min();

                smallest.Add(min);
                numbers.Remove(min);
            }

            foreach (var num in smallest)
                Console.Write($"{num} ");
            Console.WriteLine();
        }
    }
}
