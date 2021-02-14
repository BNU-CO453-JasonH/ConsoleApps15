using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This App calculates the user's Body Mass Index (BMI) by taking their weight
    /// and height in either imperial or metric units. 
    /// After the values are entered, the user's BMI will be calculated and displayed, 
    /// indicating their weight status according to the W.H.O. guidelines.
    /// </summary>
    /// <author>
    /// Jason Huggins (modified 14/02/2021)
    /// </author>
    public class BMI
    {
        // Constants for W.H.O. weight status (in BMI kg/m2)
        // Maximum thresholds.
        public const double UNDERWEIGHT_MAX = 18.5;
        public const double NORMAL_MAX = 24.9;
        public const double OVERWEIGHT_MAX = 29.9;
        public const double OBESE_I_MAX = 34.9;
        public const double OBESE_II_MAX = 39.9;
        // Minimum threshold.
        public const double OBESE_III_MIN = 40.0;

        // Properties for height and weight in imperial units.
        // Weight = stones (st) and pounds (lb)
        // Height = feet (ft) and inches (in)
        public double Weight_ST { get; set; }
        public double Weight_LB { get; set; }
        public double Height_FT { get; set; }
        public double Height_IN { get; set; }

        // Properties for height and weight in metric units.
        // Weight = kilograms (kg); height = metres (m)
        public double Weight_KG { get; set; }
        public double Height_M { get; set; }

        // Property for user's BMI.
        public double User_BMI { get; set; }

        /// <summary>
        /// Outputs a heading for the App, then shows the user's BMI, weight status and
        /// health risk information after the calculation process has been completed.
        /// </summary>
        public void OutputBMI()
        {
            ConsoleHelper.OutputHeading("Body Mass Index Calculator");

            SelectUnits();

            Console.WriteLine("\n\tYour BMI is " + Math.Round(User_BMI, 1));
            Console.WriteLine("\tWeight status: " + DisplayWeightStatus());

            DisplayRiskMessage();

            ExitDecision();
        }

        /// <summary>
        /// Prompts the user to select which unit type they would like to use.
        /// (1 for imperial; 2 for metric)
        /// </summary>
        private void SelectUnits()
        {
            Console.WriteLine("\tWhich unit type would you like to use?");

            string[] choices = { "Imperial", "Metric" };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                CalculateImperial();
            }
            else if (choice == 2)
            {
                CalculateMetric();
            }
            else
            {
                Console.WriteLine("\tInvalid choice. Please try again.");
                SelectUnits();
            }
        }

        /// <summary>
        /// Prompts the user to enter their weight and height in imperial units,
        /// then calculates their BMI.
        /// </summary>
        private void CalculateImperial()
        {
            Weight_ST = ConsoleHelper.InputNumber("\n\tPlease enter your weight in stones > ");
            Weight_LB = ConsoleHelper.InputNumber("\tPlease enter your weight in pounds > ");
            Height_FT = ConsoleHelper.InputNumber("\n\tPlease enter your height in feet > ");
            Height_IN = ConsoleHelper.InputNumber("\tPlease enter your height in inches > ");

            User_BMI = Weight_LB * 703 / Math.Pow(Height_IN, 2);
        }

        /// <summary>
        /// Prompts the user to enter their weight and height in metric units,
        /// then calculates their BMI.
        /// </summary>
        private void CalculateMetric()
        {
            Weight_KG = ConsoleHelper.InputNumber("\n\tPlease enter your weight in kilograms > ");
            Height_M = ConsoleHelper.InputNumber("\n\tPlease enter your height in metres > ");

            User_BMI = Weight_KG / Math.Pow(Height_M, 2);
        }

        /// <summary>
        /// Determines the weight status of the user based on their BMI and the W.H.O's
        /// weight status guidelines. 
        /// </summary>
        /// <returns>A string with the user's current weight status.</returns>
        private string DisplayWeightStatus()
        {
            if (User_BMI < UNDERWEIGHT_MAX)
            {
                return "Underweight";
            }
            else if ((User_BMI > UNDERWEIGHT_MAX) && (User_BMI <= NORMAL_MAX))
            {
                return "Normal";
            }
            else if ((User_BMI > NORMAL_MAX) && (User_BMI <= OVERWEIGHT_MAX))
            {
                return "Overweight";
            }
            else if ((User_BMI > OVERWEIGHT_MAX) && (User_BMI <= OBESE_I_MAX))
            {
                return "Obese Class I";
            }
            else if ((User_BMI > OBESE_I_MAX) && (User_BMI <= OBESE_III_MIN))
            {
                return "Obese Class II";
            }
            else if (User_BMI >= OBESE_III_MIN)
            {
                return "Obese Class III";
            }

            return null;
        }

        /// <summary>
        /// Outputs a message regarding Black, Asian and other minority ethnic
        /// groups having a higher health risk. 
        /// </summary>
        private void DisplayRiskMessage()
        {
            Console.WriteLine("\n\tIf you are Black, Asian or in another minority " +
                "ethnic group, you have a higher health risk.");
            Console.WriteLine("\n\tAdults with a BMI of 23.0 or over " +
                "are at increased risk.");
            Console.WriteLine("\tAdults with a BMI of 27.5 or over " +
                "are at high risk.");
        }

        /// <summary>
        /// Gives the user the option to either exit the application or return
        /// to the menu to calculate another BMI result.
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
                SelectUnits();
            }
            else
            {
                Console.WriteLine("\tInvalid input. Please try again.");
                ExitDecision();
            }
        }
    }
}
