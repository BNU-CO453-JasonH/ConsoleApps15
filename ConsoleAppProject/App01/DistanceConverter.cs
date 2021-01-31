using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App converts a user-inputted distance in miles into its distance in feet, displaying the result to the user afterwards.
    /// </summary>
    /// <author>
    /// Jason Huggins (modified 31/01/2021)
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        private double miles;
        private double feet;

        /// <summary>
        /// Runs the application.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Prints a heading for the application on start.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("   Miles to Feet Conversion   ");
            Console.WriteLine("       By Jason Huggins       ");
            Console.WriteLine("------------------------------\n");
        }

        /// <summary>
        /// Prompt the user to input the distance in miles (as a double number).
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles = ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Calculates the conversion of the distance in miles (inputted by the user) into the distance in feet.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }


        /// <summary>
        /// Outputs the conversion result (the distance in feet) to the user.
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " mile(s) = " + feet + " feet.");
        }
    }
}
