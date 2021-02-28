using ConsoleAppProject.App03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades
            studentGrades = new StudentGrades();

        // TODO: 12 unit tests for each grade boundary (highest and lowest)
        [TestMethod]
        public void TestConvert0ToGradeF()
        { 
            Grades expectedGrade = Grades.F;
            Grades actualGrade = studentGrades.ConvertToGrade(0);

            Assert.AreEqual(expectedGrade, actualGrade);
        }
    }
}
