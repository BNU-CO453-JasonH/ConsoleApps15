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
        /// Prompts the user to input a distance to convert from.
        /// </summary>
        /// <param name="prompt">The prompt that will be displayed to the user.</param>
        /// <returns>Their inputted value as a double.</returns>
        private double InputDistance(string prompt)
        {
            Console.Write("\n" + prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }
        
        /// <summary>
        /// Outputs the converted distance to the user.
        /// </summary>
        /// <param name="fromDistance">The distance to be converted from.</param>
        /// <param name="fromUnit">The unit of the distance to be converted from.</param>
        /// <param name="toDistance">The distance to be converted to.</param>
        /// <param name="toUnit">The unit of the distance to be converted to.</param>
        private void OutputDistance(double fromDistance, string fromUnit, 
                                    double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} = {toDistance} {toUnit}");
        }

        /// <summary>
        /// Asks the user to input a distance in miles, which is then converted into feet and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMilesToFeet()
        {
            Console.WriteLine("Miles -> Feet Conversion");

            Miles = InputDistance("Please enter the number of miles = ");
            Feet = Miles * FEET_IN_MILES;

            OutputDistance(Miles, "mile(s)", Feet, "feet");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in feet, which is then converted into miles and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertFeetToMiles()
        {
            Console.WriteLine("Feet -> Miles Conversion");

            Feet = InputDistance("Please enter the number of feet = ");
            Miles = Feet / FEET_IN_MILES;

            OutputDistance(Feet, "feet", Miles, "mile(s)");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in miles, which is then converted into metres and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMilesToMetres()
        {
            Console.WriteLine("Miles -> Metres Conversion");

            Miles = InputDistance("Please enter the number of miles = ");
            Metres = Miles * METRES_IN_MILES;

            OutputDistance(Miles, "mile(s)", Metres, "metres(s)");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in metres, which is then converted into miles and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMetresToMiles()
        {
            Console.WriteLine("Metres -> Miles Conversion");

            Metres = InputDistance("Please enter the number of metres = ");
            Miles = Metres / METRES_IN_MILES;

            OutputDistance(Metres, "metre(s)", Miles, "mile(s)");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in metres, which is then converted into feet and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMetresToFeet()
        {
            Console.WriteLine("Metres -> Feet Conversion");

            Metres = InputDistance("Please enter the number of metres = ");
            Feet = Metres * FEET_IN_METRES;

            OutputDistance(Metres, "metre(s)", Feet, "feet");

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to input a distance in feet, which is then converted into metres and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertFeetToMetres()
        {
            Console.WriteLine("Feet -> Metres Conversion");

            Feet = InputDistance("Please enter the number of feet = ");
            Metres = Feet / FEET_IN_METRES;

            OutputDistance(Feet, "feet", Metres, "metre(s)");

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
