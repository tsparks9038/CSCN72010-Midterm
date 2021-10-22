using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class SortArrayTest
    {
        private Student[] studentArray;

        [TestInitialize]
        public void TestInit()
        {
            studentArray = new Student[10];
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
        public void SortTwo()
        {
            StudentCreation.CreateStudent("Test", "Dummy", studentArray);
            StudentCreation.CreateStudent("Cool", "Guy", studentArray);
            EditGrade.UpdateGrade(studentArray, 1, 75);

            SortArray.Sort(studentArray);

            Assert.AreEqual(75, studentArray[1].grade);
        }

        [TestMethod]
        public void SortTen()
        {
            StudentCreation.CreateStudent("Test", "Dummy", studentArray);
            StudentCreation.CreateStudent("Cool", "Guy", studentArray);
            StudentCreation.CreateStudent("Barack", "Obama", studentArray);
            StudentCreation.CreateStudent("Donald", "Trump", studentArray);
            StudentCreation.CreateStudent("Xi", "Jinping", studentArray);
            StudentCreation.CreateStudent("Phoenix", "Wright", studentArray);
            StudentCreation.CreateStudent("Ai", "Ai", studentArray);
            StudentCreation.CreateStudent("Man", "Guy", studentArray);
            StudentCreation.CreateStudent("Guy", "Guy", studentArray);
            StudentCreation.CreateStudent("Cool", "Man", studentArray);
            EditGrade.UpdateGrade(studentArray, 1, 75);
            EditGrade.UpdateGrade(studentArray, 5, 100);
            EditGrade.UpdateGrade(studentArray, 6, 96);

            SortArray.Sort(studentArray);

            Assert.AreEqual(100, studentArray[5].grade);
        }
    }
}
