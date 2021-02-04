using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App converts a user-inputted distance in either miles, feet or metres (selected by the user at the start),
    /// converting it into its equivalent distance in another unit (e.g. , displaying the result to the user afterwards.
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
        /// Asks the user to input a distance in miles, which is then converted into feet and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMilesToFeet()
        {
            Console.Write("\nPlease enter the number of miles = ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            
            feet = miles * FEET_IN_MILES;

            Console.WriteLine(miles + " mile(s) = " + feet + " feet.");

            Console.WriteLine("Please ENTER to return to the menu.");
            Console.ReadLine();
            SelectChoice();
        }

        /// <summary>
        /// Asks the user to input a distance in feet, which is then converted into miles and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertFeetToMiles()
        {
            Console.Write("\nPlease enter the number of feet = ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

            miles = feet / FEET_IN_MILES;

            Console.WriteLine(feet + " feet = " + miles + " mile(s).");

            Console.WriteLine("Please ENTER to return to the menu.");
            Console.ReadLine();
            SelectChoice();
        }

        /// <summary>
        /// Asks the user to input a distance in miles, which is then converted into metres and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMilesToMetres()
        {
            Console.Write("\nPlease enter the number of miles = ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            
            metres = miles * METRES_IN_MILES;

            Console.WriteLine(miles + " mile(s) = " + metres + " metre(s).");

            Console.WriteLine("Please ENTER to return to the menu.");
            Console.ReadLine();
            SelectChoice();
        }

        /// <summary>
        /// Asks the user to input a distance in metres, which is then converted into miles and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMetresToMiles()
        {
            Console.Write("\nPlease enter the number of metres = ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);

            miles = metres / METRES_IN_MILES;

            Console.WriteLine(metres + " metre(s) = " + miles + " mile(s).");

            Console.WriteLine("Please ENTER to return to the menu.");
            Console.ReadLine();
            SelectChoice();
        }

        /// <summary>
        /// Asks the user to input a distance in metres, which is then converted into feet and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertMetresToFeet()
        {
            Console.Write("\nPlease enter the number of metres = ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);

            feet = metres * FEET_IN_METRES;

            Console.WriteLine(metres + " metre(s) = " + feet + " feet.");

            Console.WriteLine("Please ENTER to return to the menu.");
            Console.ReadLine();
            SelectChoice();
        }

        /// <summary>
        /// Asks the user to input a distance in feet, which is then converted into metres and the result is 
        /// displayed on-screen.
        /// </summary>
        private void ConvertFeetToMetres()
        {
            Console.Write("\nPlease enter the number of feet = ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);

            metres = feet / FEET_IN_METRES;

            Console.WriteLine(feet + " feet = " + metres + " metre(s).");

            Console.WriteLine("Please ENTER to return to the menu.");
            Console.ReadLine();
            SelectChoice();
        }
    }
}
