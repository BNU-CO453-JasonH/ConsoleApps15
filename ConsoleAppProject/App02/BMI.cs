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
        public const double OBESE_II_MIN = 40.0;

        // Properties for height and weight in imperial units.
        // Weight = stones (st) and pounds (lb)
        // Height = feet (ft) and inches (in)
        public int Weight_ST { get; set; }
        public int Weight_LB { get; set; }
        public int Height_FT { get; set; }
        public int Height_IN { get; set; }

        // Properties for height and weight in metric units.
        // Weight = kilograms (kg); height = metres (m)
        public int Weight_KG { get; set; }
        public int Height_M { get; set; }


    }
}
