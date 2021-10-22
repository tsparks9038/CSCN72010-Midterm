using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class StudentCreationTest
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
        public void IsFirstArrayIndexFull()
        {
            string firstName = "Barack";
            string lastName = "Obama";

            StudentCreation.CreateStudent(firstName, lastName, studentArray);

            Assert.AreEqual(1, Array.FindIndex(studentArray, i => i == null));
        }

        [TestMethod]
        public void WillTwoIndexesFill()
        {
            string firstName = "Xi";
            string lastName = "Jinping";
            string firstName2 = "Donald";
            string lastName2 = "Trump";

            StudentCreation.CreateStudent(firstName, lastName, studentArray);
            StudentCreation.CreateStudent(firstName2, lastName2, studentArray);

            Assert.AreEqual(2, Array.FindIndex(studentArray, i => i == null));
        }
    }
}
