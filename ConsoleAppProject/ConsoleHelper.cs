using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// This class handles the console input and output for the Apps
    /// within this project so it remains consistent.
    /// </summary>
    /// <author>
    /// Jason Huggins (modified 11/02/2021)
    /// </author>
    public static class ConsoleHelper
    {
        /// <summary>
        /// Prints a heading for each App with its title and author.
        /// </summary>
        /// <param name="title">The title of the application.</param>
        public static void OutputHeading(string title)
        {
            Console.WriteLine("\n\t-------------------------------------");
            Console.WriteLine($"\t{title}");
            Console.WriteLine("\t\tBy Jason Huggins");
            Console.WriteLine("\t-------------------------------------\n");
        }

        /// <summary>
        /// Shows the choices to the user as a numbered list.
        /// </summary>
        /// <param name="choices">The list of choices the user can make.</param>
        public static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++; // Incremented at the start so it begins at 1.
                Console.WriteLine($"\n\t{choiceNo}. {choice}");
            }
        }

        /// <summary>
        /// Gives the user a prompt to input a valid number. After a valid input,
        /// it's returned.
        /// </summary>
        /// <param name="prompt">Prompts the user to input a valid number.</param>
        /// <returns>The user's input number if valid.</returns>
        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool isValid;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    isValid = true;
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.WriteLine("\tInvalid number.\n");
                }
            } while (!isValid);

            return number;
        }

        /// <summary>
        /// Gives the user a prompt to enter a valid number, repeatedly doing
        /// so until they do. Their value will only be returned if it's 
        /// between the mix and max range. 
        /// </summary>
        /// <param name="prompt">Prompts the user to input a valid number.</param>
        /// <param name="min">The minimum accepted threshold for the input.</param>
        /// <param name="max">The maximum accepted threshold for the input.</param>
        /// <returns></returns>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid;
            double number;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"\tThe number must be in the range " +
                        $"{min}-{max}");
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            return number;
        }

        /// <summary>
        /// Shows the user a numbered list of choices, prompting them
        /// to choose one and this will be returned.
        /// </summary>
        /// <param name="choices">The list of choices the user can make.</param>
        /// <returns>The choice number selected by the user.</returns>
        public static int SelectChoice(string[] choices)
        {
            int choiceNo;
            int lastChoice = choices.Length;
            bool isValid;

            string errorMsg = $"\n\tInvalid choice, it must be between 1 to {lastChoice}.";

            do
            {
                DisplayChoices(choices);

                choiceNo = (int)InputNumber("\tPlease input choice > ", 1, lastChoice);

                if ((choiceNo < 1) || (choiceNo > lastChoice))
                {
                    isValid = false;
                    Console.WriteLine(errorMsg);
                }
                else
                {
                    isValid = true;
                }
            } while (!isValid);

            return choiceNo;
        }
    }
}
