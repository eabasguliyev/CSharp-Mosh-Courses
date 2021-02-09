using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TextsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program and ask the user to enter a few numbers separated by a hyphen.
             * Work out if the numbers are consecutive.
             * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
             */

            //Console.Write("Enter a few numbers separated by a hyphen: ");
            //var input = Console.ReadLine();
            //Console.WriteLine(ConsecutiveChecker(input));

            /*
             * Write a program and ask the user to enter a few numbers separated by a hyphen.
             * If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
             * If so, display "Duplicate" on the console.
             */
            //Console.Write("Enter a few numbers separated by a hyphen: ");
            //var input = Console.ReadLine();
            //Console.WriteLine(checkDuplicates(input));


            /*
             * Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
             * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
             * If the user doesn't provide any values, consider it as invalid time.
             */
            //Console.Write("Enter a 24 hour time format(e.g. 19:00) : ");
            //var input = Console.ReadLine();
            //Console.WriteLine(timeFormatChecker(input));


            /*
             * Write a program and ask the user to enter a few words separated by a space.
             * Use the words to create a variable name with PascalCase.
             * For example, if the user types: "number of students", display "NumberOfStudents".
             * Make sure that the program is not dependent on the input.
             * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
             */

            //Console.Write("Enter a few words separated by whitespace: ");
            //var input = Console.ReadLine();
            //convertToPascalCase(input);

            /*
             * Write a program and ask the user to enter an English word.
             * Count the number of vowels (a, e, o, u, i) in the word.
             * So, if the user enters "inadequate", the program should display 6 on the console.
             */
            //Console.Write("Enter a word: ");
            //var input = Console.ReadLine();
            //countVowels(input);

        }

        public static bool ConsecutiveChecker(string data)
        {
            List<int> numbers = new List<int>();

            foreach (var num in data.Split('-'))
            {
               numbers.Add(Convert.ToInt32(num)); 
            }
            
            var isConsecutive = true;
            numbers.Sort();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] + 1 != numbers[i + 1])
                {
                    isConsecutive = false;
                    break;
                }
            }

            return isConsecutive;
        }

        static bool checkDuplicates(string data)
        {
            var numbers = new List<int>();

            foreach (var num in data.Split('-'))
                numbers.Add(Convert.ToInt32(num));

            
            var uniques = new List<int>();
            var includeDupclicates = false;

            foreach (var number in numbers)
            {
                if(!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includeDupclicates = true;
                    break;
                }
            }

            return includeDupclicates;
        }

        static string timeFormatChecker(string data)
        {
            if (String.IsNullOrWhiteSpace(data))
            {
                return "Invalid Time";
            }

            var components = data.Split(':');

            if (components.Length != 2)
            {
                return "Invalid Time";
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if(hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                   return "Ok";
                else
                    return"Invalid Time";
            }
            catch (Exception)
            {
                return "Invalid Time";
            }
        }

        static string convertToPascalCase(string data)
        {
            var variableName = "";

            foreach (var word in data.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.Substring(1);
                variableName += wordWithPascalCase;
            }

            return variableName;
        }

        static int countVowels(string word)
        {
            char[] vowels = new char[] {'a', 'e', 'o', 'u', 'i'};
            var vowelsCount = 0;

            word = word.ToLower();

            foreach (var @char in word)
            {
                if (vowels.Contains(@char))
                    vowelsCount++;
            }

            return vowelsCount;
        }
    }
}
