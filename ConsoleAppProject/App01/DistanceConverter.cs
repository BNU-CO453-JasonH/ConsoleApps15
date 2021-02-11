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
        // Constants for distance conversion
        public const int FEET_IN_MILES = 5280;
        public const double FEET_IN_METRES = 3.28084;
        public const double METRES_IN_MILES = 1609.34;

        // Properties
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }

        /// <summary>
        /// Constructor for the DistanceConverter class.
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

        // TODO: See week 3 slides and create a ConsoleHelper class.
        /// <summary>
        /// Prints a heading for the converter with the application's name and developer.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n\t--------------------------------------------------------");
            Console.WriteLine("\t  Distance Conversion Calculator (Miles, Feet, Metres)    ");
            Console.WriteLine("\t                  By Jason Huggins                        ");
            Console.WriteLine("\t--------------------------------------------------------\n");
        }

        /// <summary>
        /// Asks the user to input a distance, which is then converted into the unit 
        /// they selected at the start, and the result is 
        /// displayed on-screen.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            FromUnit = SelectUnit("\tPlease enter the unit you'd like to convert from > ");
            ToUnit = SelectUnit("\tPlease enter the unit you'd like to convert to > ");

            Console.WriteLine($"\n\t{FromUnit} -> {ToUnit} Conversion");

            FromDistance = InputDistance($"Please enter the number of {FromUnit} = ");

            CalculateDistance();

            OutputDistance();

            ExitDecision();
        }

        /// <summary>
        /// Asks the user to select their choices (source and destination distance units for conversion)
        /// and then executes the conversion.
        /// </summary>
        /// <param name="prompt">The user's selected choice.</param>
        /// <returns>The execution of the user's choice.</returns>
        public DistanceUnits SelectUnit(string prompt)
        {
            string choice = ShowChoices(prompt);

            DistanceUnits unit = ExecuteChoice(choice);
            Console.WriteLine($"\t{unit} has been selected.\n");

            return unit;
        }

        /// <summary>
        /// Shows the unit choices to the user.
        /// </summary>
        /// <param name="prompt">Prompts the user to enter a choice for the distance unit.</param>
        /// <returns>The user's selected choice.</returns>
        private string ShowChoices(string prompt)
        {
            Console.WriteLine($"\t1. {DistanceUnits.Miles}");
            Console.WriteLine($"\t2. {DistanceUnits.Feet}");
            Console.WriteLine($"\t3. {DistanceUnits.Metres}");

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Executes the conversion based on the user's choices.
        /// </summary>
        /// <param name="choice">The choice made by the user.</param>
        /// <returns>The unit representing the user's choice.</returns>
        private DistanceUnits ExecuteChoice(string choice)
        {
            DistanceUnits unit;

            switch (choice)
            {
                case "1":
                    unit = DistanceUnits.Miles;
                    break;
                case "2":
                    unit = DistanceUnits.Feet;
                    break;
                case "3":
                    unit = DistanceUnits.Metres;
                    break;
                default:
                    unit = DistanceUnits.NoUnit;
                    break;
            }
        
            // TODO: Fix so it asks the user to input their choice again rather than proceeding. 
            if (unit == DistanceUnits.NoUnit)
            {
                Console.WriteLine("Invalid choice. Your choice must be in" +
                    " the range 1-3.");
            }

            return unit;
        }

        /// <summary>
        /// Prompts the user to input a distance to convert from.
        /// </summary>
        /// <param name="prompt">The prompt that will be displayed to the user.</param>
        /// <returns>Their inputted value as a double.</returns>
        private double InputDistance(string prompt)
        {
            Console.Write("\n\t" + prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Outputs the converted distance to the user.
        /// </summary>
        /// <param name="FromDistance">The distance to be converted from.</param>
        /// <param name="FromUnit">The unit of the distance to be converted from.</param>
        /// <param name="ToDistance">The distance to be converted to.</param>
        /// <param name="ToUnit">The unit of the distance to be converted to.</param>
        private void OutputDistance()
        {
            Console.WriteLine($"\t{FromDistance} {FromUnit} = {ToDistance} {ToUnit}");
        }

        /// <summary>
        /// Calculates the distance conversion depending on the units selected
        /// by the user at the start.
        /// </summary>
        private void CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
        }

        /// <summary>
        /// Gives the user the option to either exit the application after getting a conversion result or return
        /// to the menu to convert another distance.
        /// </summary>
        private void ExitDecision()
        {
            Console.Write("\n\tWould you like to exit? Selecting 'n' will return you to the menu (y/n) > ");

            string choice = Console.ReadLine();

            if (choice == "y")
            {
                Console.WriteLine("\tThank you for using this calculator. Goodbye for now!");
                Environment.Exit(0);
            }
            else if (choice == "n")
            {
                ConvertDistance();
            }
            else
            {
                Console.WriteLine("\tInvalid input. Please try again.");
                ExitDecision();
            }
        }
    }
}
