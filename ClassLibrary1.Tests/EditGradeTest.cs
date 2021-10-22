using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class EditGradeTest
    {
        private Student[] studentArray;

        [TestInitialize]
        public void TestInit()
        {
            studentArray = new Student[10];
            string firstName = "Barack";
            string lastName = "Obama";

            StudentCreation.CreateStudent(firstName, lastName, studentArray);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (studentArray != null)
            {
                studentArray = null;
            }
        }

        [TestMethod]
        public void GradeWillUpdateCorrectly()
        {
            EditGrade.UpdateGrade(studentArray, 0, 75);

            Assert.AreEqual(75, studentArray[0].grade);
        }

        [TestMethod]
        public void ThreeDigitGrade()
        {
            EditGrade.UpdateGrade(studentArray, 0, 100);

            Assert.AreEqual(100, studentArray[0].grade);
        }
    }
}
