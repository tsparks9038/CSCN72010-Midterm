using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EditGrade
    {
        public static void UpdateGrade(Student[] studentArray, int indexValue, int grade)
        {
            studentArray[indexValue].grade = grade;

            SortArray.Sort(studentArray);
        }
    }
}
