using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string studentID;
        public int grade;

        public Student()
        {
            firstName = "\0";
            lastName = "\0";
            studentID = "\0";
            grade = 0;
        }

        public Student(string firstName, string lastName, string studentID, int grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = studentID;
            this.grade = grade;
        }
    }
}
