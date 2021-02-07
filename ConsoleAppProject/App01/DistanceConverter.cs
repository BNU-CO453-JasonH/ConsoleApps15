using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App converts a user-inputted distance in either miles, feet or metres (selected by the user at the start),
    /// converting it into its equivalent distance in another unit (e.g. , displaying the result to the user afterwards.
    /// </summary>
    /// <author>
    /// Jason Huggins (modified 07/02/2021)
    /// </author>
    public class DistanceConverter
    {
        // Constants
        public const int FEET_IN_MILES = 5280;
        public const double FEET_IN_METRES = 3.28084;
        public const double METRES_IN_MILES = 1609.34;

        // Attributes
        public double Miles { get; set; }
        public double Feet { get; set; }
        public double Metres { get; set; }

        /// <summary>
        /// Asks the user to choose which distance units they want to convert to/from.
        /// </summary>
        public void SelectChoice()
        {
            OutputHeading();

            Console.Write("Please enter the unit you'd like to convert from ('miles', 'feet' or 'metres') > ");
            string sourceUnit = Console.ReadLine();

            Console.Write("\nPlease enter the unit you'd like to convert to ('miles', 'feet' or 'metres') > ");
            string destinationUnit = Console.ReadLine();

            if (sourceUnit == "miles" && destinationUnit == "feet")
            {
                ConvertMilesToFeet();
            }
            else if (sourceUnit == "feet" && destinationUnit == "miles")
            {
                ConvertFeetToMiles();
            }
            else if (sourceUnit == "miles" && destinationUnit == "metres")
            {
                ConvertMilesToMetres();
            }
            else if (sourceUnit == "metres" && destinationUnit == "miles")
            {
                ConvertMetresToMiles();
            }
            else if (sourceUnit == "metres" && destinationUnit == "feet")
            {
                ConvertMetresToFeet();
            }
            else if (sourceUnit == "feet" && destinationUnit == "metres")
            {
                ConvertFeetToMetres();
            }
            else
            {
                // TODO: Needs fixing so it doesn't end the program immediately after an invalid input.
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        /// <summary>
        /// Prints a heading for the application.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------------------------------   ");
            Console.WriteLine("       Distance Conversion Calculator (Miles, Feet, Metres)      ");
            Console.WriteLine("                       By Jason Huggins                          ");
            Console.WriteLine("---------------------------------------------------------------\n");
        }

        /// <summary>
        /// Gives the user the option to either exit the application after getting a conversion result or return
        /// to the menu to convert another distance.
        /// </summary>
        private void ExitDecision()
        {
            Console.Write("\nWould you like to exit? Selecting 'n' will return you to the menu (y/n) > ");

            string choice = Console.ReadLine();

            if (choice == "y")
            {
                Console.WriteLine("Thank you for using this calculator. Goodbye for now!");
                Environment.Exit(0);
            }
            else if (choice == "n")
            {
                SelectChoice();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                ExitDecision();
            }
        }

        /// <summary>
        /// Asks the user to input a distance in miles, which is then converted into feet and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMilesToFeet()
        {
            Console.Write("\nPlease enter the number of miles = ");
            string value = Console.ReadLine();
            Miles = Convert.ToDouble(value);

            Feet = Miles * FEET_IN_MILES;

            Console.WriteLine(Miles + " mile(s) = " + Feet + " feet.");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in feet, which is then converted into miles and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertFeetToMiles()
        {
            Console.Write("\nPlease enter the number of feet = ");
            string value = Console.ReadLine();
            Feet = Convert.ToDouble(value);

            Miles = Feet / FEET_IN_MILES;

            Console.WriteLine(Feet + " feet = " + Miles + " mile(s).");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in miles, which is then converted into metres and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMilesToMetres()
        {
            Console.Write("\nPlease enter the number of miles = ");
            string value = Console.ReadLine();
            Miles = Convert.ToDouble(value);

            Metres = Miles * METRES_IN_MILES;

            Console.WriteLine(Miles + " mile(s) = " + Metres + " metre(s).");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in metres, which is then converted into miles and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMetresToMiles()
        {
            Console.Write("\nPlease enter the number of metres = ");
            string value = Console.ReadLine();
            Metres = Convert.ToDouble(value);

            Miles = Metres / METRES_IN_MILES;

            Console.WriteLine(Metres + " metre(s) = " + Miles + " mile(s).");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in metres, which is then converted into feet and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMetresToFeet()
        {
            Console.Write("\nPlease enter the number of metres = ");
            string value = Console.ReadLine();
            Metres = Convert.ToDouble(value);

            Feet = Metres * FEET_IN_METRES;

            Console.WriteLine(Metres + " metre(s) = " + Feet + " feet.");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in feet, which is then converted into metres and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertFeetToMetres()
        {
            Console.Write("\nPlease enter the number of feet = ");
            string value = Console.ReadLine();
            Feet = Convert.ToDouble(value);

            Metres = Feet / FEET_IN_METRES;

            Console.WriteLine(Feet + " feet = " + Metres + " metre(s).");

            ExitDecision();
        }
    }
}
