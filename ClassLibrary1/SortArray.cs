﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SortArray
    {
        public static void Sort(Student[] studentArray)
        {
            var sortedArray = from g in studentArray orderby g.grade select g;
        }
    }
}
