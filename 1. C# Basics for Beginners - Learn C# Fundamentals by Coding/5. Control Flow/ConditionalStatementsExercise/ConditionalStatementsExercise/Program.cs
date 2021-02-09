using System;

namespace ConditionalStatementsExercise
{
    class Program
    {
        public enum Orientation
        {
            Portrait,
            Landscape
        }
        static void Main(string[] args)
        {
            /*
             * 1- Write a program and ask the user to enter a number. The number should be between 1 to 10.
             * If the user enters a valid number, display "Valid" on the console.
             * Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
             */
            //Console.Write("Enter number [1-10]: ");
            //var number = Convert.ToInt32(Console.ReadLine());

            //if (number > 0 && number < 11)
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("Invalid");

            /*
             * 2- Write a program which takes two numbers from the console and displays the maximum of the two.
             */

            //int num1, num2;
            //Console.Write("Enter num1: ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter num2: ");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //int max = (num1 > num2) ? num1 : num2;

            //Console.WriteLine($"Max value is {max}");

            /*
             * Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
             */
            //int width, height;
            //Console.Write("Width: ");
            //width = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Height: ");
            //height = Convert.ToInt32(Console.ReadLine());

            //var orientation = (width > height) ? Orientation.Landscape : Orientation.Portrait;

            //Console.WriteLine($"Orientation is {orientation}");

            /*
             * Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
             * Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
             * If the user enters a value less than the speed limit, program should display Ok on the console.
             * If the value is above the speed limit, the program should calculate the number of demerit points.
             * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
             * If the number of demerit points is above 12, the program should display License Suspended.
             */
            //int speedLimit, speedOfCar;

            //Console.Write("Speed limit: ");
            //speedLimit = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Speed of car: ");
            //speedOfCar = Convert.ToInt32(Console.ReadLine());

            //if(speedOfCar < speedLimit)
            //    Console.WriteLine("OK");
            //else
            //{
            //    const int kmPerDemeritPoint = 5;
            //    int demeritPoints = (speedOfCar - speedLimit) / kmPerDemeritPoint;

            //    if(demeritPoints > 12)
            //        Console.WriteLine("License is suspended");
            //    else
            //        Console.WriteLine($"Demerit points is {demeritPoints}");
            //}
        }
    }
}
