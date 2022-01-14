using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_6._3
{

    static class StudentsComparsion
    {
        public static void SortByFirstName(List<Student> students)
        {
            students.Sort((Student st1, Student st2) => (String.Compare(st1.firstName, st2.firstName)));
        }


    }
}
