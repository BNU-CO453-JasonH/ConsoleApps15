using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Jason Huggins 01/03/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputHeading("CO453 C# Console Applications 2021");

            string[] choices = { "App01: Distance Converter",
                                 "App02: BMI Calculator",
                                 "App03: Student Marks",
                                 "App04: Social Network",
                                 "App05: RPS Game",
                                 "Exit"};

            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1:
                    DistanceConverter converter = new DistanceConverter();
                    converter.ConvertDistance();
                    break;
                case 2:
                    BMICalculator bmi_calculator = new BMICalculator();
                    bmi_calculator.OutputBMI();
                    break;
                case 3:
                    StudentGrades studentGrades = new StudentGrades();
                    studentGrades.OutputHeading();
                    break;
                case 4:
                    // Code to start App04 here
                    break;
                case 5:
                    // Code to start App05 here
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
