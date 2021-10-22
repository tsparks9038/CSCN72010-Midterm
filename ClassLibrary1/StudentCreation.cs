using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentCreation
    {
        public static void CreateStudent(string firstName, string lastName, Student[] studentArray)
        {
            string studentID = firstName[0] + lastName[0] + Rng.GenerateValue();
            int freeSpot = Array.FindIndex(studentArray, i => i == null);

            Student s = new(firstName, lastName, studentID, 0);

            //if (Array.FindIndex(studentArray, i => i == null) == 10)
            //{
            //    throw new ArrayFullException("Class is full", studentArray);
            //}

            studentArray[freeSpot] = s;
        }
    }
}
