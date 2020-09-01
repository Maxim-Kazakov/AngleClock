using System;
namespace FunctionAngleHourMinut
{
    class Program
    {   /// <summary>
        /// Function for calculating the angle between the hour and minute hands
        /// </summary>
        /// <param name="hour"> Value hour hand </param>
        /// <param name="minut"> Value minute hand </param>
        /// <returns> Return the angle between hands </returns>
        public static double AngleHourMinut(double hour, double minut)
        {
            double minutAngle = (minut / 60) * 360;                                     // Calculation angle minute hand
            double hourAngle = (360 * (hour % 12) / 12) + (360 * (minut / 60) / 12);    // Calculation angle hour hand
            return Math.Abs(hourAngle - minutAngle) % 360;                              // Return the angle between hands

        }
        static void Main(string[] args)
        {
            Console.Title = "My first program for Silicon Valley";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This program calculates the angle between the hour and the minute hands on watch."); // Purpose of the program
            Console.Write("\nPlease enter value for hour hand: ");                                                  // Query value hour hands
            double h = Convert.ToDouble(Console.ReadLine());                                                        // Assigning value hour hands to a variable "h"
            Console.Write("Please enter value for minute hand: ");                                                  // Qury value minut hands
            double m = Convert.ToDouble(Console.ReadLine());                                                        // Assigning value minute hands to a variable "m"
            if ((h < 24 && h >= 0) && (m < 60 && m > 0))                                                            // Conditions of execution
            {
                Console.WriteLine($"\nAngle beetwen {h} hour and {m} minute - " + AngleHourMinut(h, m));            // Conditions true

            }
            else
            {
                Console.WriteLine("\nO MY GOD, there are no such numbers on the clock");                            // Conditions false

            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();                                                                                      
        }
    }
}
////