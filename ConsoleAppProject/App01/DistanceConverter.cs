using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App converts a user-inputted distance in either miles, feet or metres,
    /// converting it into its equivalent distance in another unit 
    /// (both units being selected by the user at the start) 
    /// and displaying the result to the user afterwards.
    /// </summary>
    /// <author>
    /// Jason Huggins (modified 11/02/2021)
    /// </author>
    public class DistanceConverter
    {
        // Constants
        public const int FEET_IN_MILES = 5280;
        public const double FEET_IN_METRES = 3.28084;
        public const double METRES_IN_MILES = 1609.34;

        // Properties
        public double Miles { get; set; }
        public double Feet { get; set; }
        public double Metres { get; set; }
        public string SourceUnit { get; set; }
        public string DestinationUnit { get; set; }

        // TODO: See week 3 slides and create a ConsoleHelper class.
        /// <summary>
        /// Prints a heading for the application.
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine("\n-------------------------------------------------------------   ");
            Console.WriteLine("       Distance Conversion Calculator (Miles, Feet, Metres)      ");
            Console.WriteLine("                       By Jason Huggins                          ");
            Console.WriteLine("---------------------------------------------------------------\n");

            SelectChoice();
        }

        /// <summary>
        /// Asks the user to select their choices (source and destination distance units for conversion).
        /// </summary>
        private void SelectChoice()
        {
            Console.Write("\nPlease enter the unit you'd like to convert from " +
                "('miles', 'feet' or 'metres') > ");

            SourceUnit = Console.ReadLine();

            Console.Write("\nPlease enter the unit you'd like to convert to" +
                " ('miles', 'feet' or 'metres') > ");

            DestinationUnit = Console.ReadLine();

            ExecuteChoice();
        }

        /// <summary>
        /// Executes the user's selected choices.
        /// </summary>
        private void ExecuteChoice()
        {
            // TODO: Refactor to use enums for units instead (see week 2 slides).
            if (SourceUnit == "miles" && DestinationUnit == "feet")
            {
                ConvertMilesToFeet();
            }
            else if (SourceUnit == "feet" && DestinationUnit == "miles")
            {
                ConvertFeetToMiles();
            }
            else if (SourceUnit == "miles" && DestinationUnit == "metres")
            {
                ConvertMilesToMetres();
            }
            else if (SourceUnit == "metres" && DestinationUnit == "miles")
            {
                ConvertMetresToMiles();
            }
            else if (SourceUnit == "metres" && DestinationUnit == "feet")
            {
                ConvertMetresToFeet();
            }
            else if (SourceUnit == "feet" && DestinationUnit == "metres")
            {
                ConvertFeetToMetres();
            }
            else if (SourceUnit == DestinationUnit)
            {
                Console.WriteLine("Both choices are the same, please enter different source and destination units.");
                SelectChoice();
            }
            else
            {
                Console.WriteLine("Invalid choice(s). Please try again.");
                SelectChoice();
            }
        }

        /// <summary>
        /// Asks the user to input a distance in miles, which is then converted into feet and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMilesToFeet()
        {
            Console.WriteLine("Miles -> Feet Conversion");
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
            Console.WriteLine("Feet -> Miles Conversion");
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
            Console.WriteLine("Miles -> Metres Conversion");
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
            Console.WriteLine("Metres -> Miles Conversion");
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
            Console.WriteLine("Metres -> Feet Conversion");
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
            Console.WriteLine("Feet -> Metres Conversion");
            Console.Write("\nPlease enter the number of feet = ");
            string value = Console.ReadLine();
            Feet = Convert.ToDouble(value);

            Metres = Feet / FEET_IN_METRES;

            Console.WriteLine(Feet + " feet = " + Metres + " metre(s).");

            ExitDecision();
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
    }
}
