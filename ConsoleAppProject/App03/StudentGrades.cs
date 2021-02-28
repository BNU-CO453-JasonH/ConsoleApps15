using System;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This app lets a tutor input marks for a number of students
    /// and convert those marks into grades based on set grade
    /// boundaries (found in the Grades enum). A range of marks
    /// including the mean, minimum and maximum, as well as
    /// grade profiles will also be calculated and displayed. 
    /// </summary>
    /// <author>
    /// Jason Huggins (modified 28/02/2021)
    /// </author>
    public class StudentGrades
    {
        // Constants for marks and grade boundaries
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        // Properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        /// <summary>
        /// Constructor creating an instance of the class and 
        /// initialises an array of students.
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Aaron", "Jack", "Dave", "Mike",
                "Lisa", "Sarah", "Ryan", "John",
                "Jennifer", "Anton", "Isabella"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        // TODO: Write method for user input.
        public void SelectChoice()
        {
            /// 1. Input Marks (method incomplete)
            /// 2. Output Marks (method incomplete)
            /// 3. Output Stats (method incomplete)
            /// 4. Output Grade Profile (method incomplete)
            /// 5. Exit (method incomplete)
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompts the user to input a mark in the range
        /// 0-100 for each student and stores it in the
        /// array. If the input isn't in this range, an
        /// error is shown.
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Displays a list of the students with their
        /// names, current marks and grades.
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts a student's mark to a grade
        /// based on the set grade boundaries in
        /// the Grades enum.
        /// </summary>
        /// <param name="mark">The mark to be converted.</param>
        /// <returns>The grade based on the given mark.</returns>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }

            // Returns N/A by default.
            return Grades.N;
        }

        /// <summary>
        /// Calculates the mean, minimum and
        /// maximum marks for all students.
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
                if (mark < Minimum)
                {
                    Minimum = mark;
                }

                total += mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// Outputs the mean, minimum and
        /// maximum marks for all students.
        /// </summary>
        public void OutputStats()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the grade profile containing the 
        /// percentage of students attaining each grade.
        /// </summary>
        public void CalculateGradeProfile()
        {
            // Clears the grade profile before use.
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }

        /// <summary>
        /// Displays the grade profile after it has been
        /// calculated.
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.N;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"\tGrade {grade} \t{percentage}%" +
                    $" \tCount {count}");
                grade++;
            }

            Console.WriteLine();
        }
    }
}
