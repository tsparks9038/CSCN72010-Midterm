using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class EditGrade
    {
        public static void UpdateGrade(Student[] studentArray, int indexValue, int grade)
        {
            studentArray[indexValue].grade = grade;

            SortArray.SortStub();
        }

        public static void UpdateGradeStub()
        {
            Console.WriteLine("UpdateGradeStub() called\n");
        }
    }
}
