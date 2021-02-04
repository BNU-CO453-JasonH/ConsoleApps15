using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App converts a user-inputted distance in either miles, feet or metres (selected by the user at the start) ,
    /// converting it into its equivalent distance in another measure (e.g. , displaying the result to the user afterwards.
    /// </summary>
    /// <author>
    /// Jason Huggins (modified 04/02/2021)
    /// </author>
    public class DistanceConverter
    {
        // Constants
        public const int FEET_IN_MILES = 5280;
        public const double FEET_IN_METRES = 3.28084;
        public const double METRES_IN_MILES = 1609.34;

        // Attributes
        private double miles;
        private double feet;
        private double metres;

        /// <summary>
        /// Runs the application.
        /// </summary>
        public void ConvertMilesToFeet()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Runs the application.
        /// </summary>
        public void ConvertFeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        /// <summary>
        /// Prints a heading for the application on start.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------------------------------   ");
            Console.WriteLine("       Distance Conversion Calculator (Miles, Feet, Metres)      ");
            Console.WriteLine("                       By Jason Huggins                          ");
            Console.WriteLine("---------------------------------------------------------------\n");
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
        /// Prompt the user to input the distance in miles (as a double number).
        /// </summary>
        private void InputFeet()
        {
            Console.Write("Please enter the number of feet = ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// Calculates the conversion of the distance in miles (inputted by the user) into the distance in feet.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
            // miles = feet / FEET_IN_METRES;
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
