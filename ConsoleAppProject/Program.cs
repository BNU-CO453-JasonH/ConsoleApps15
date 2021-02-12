using System;
using ConsoleAppProject.App01;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Jason Huggins 11/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputHeading("CO453 - C# Console Applications 2021");

            string[] choices = { "Distance Converter",
                                 "BMI Calculator"   };

            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1:
                    DistanceConverter converter = new DistanceConverter();
                    converter.ConvertDistance();
                    break;
                case 2:
                    // TODO: Add the BMI calculator here when ready.
                    break;
                default:
                    break;
            }
        }
    }
}
