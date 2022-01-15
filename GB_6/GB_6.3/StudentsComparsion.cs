using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_6._3
{

    /*    3. Переделать программу Пример использования коллекций для решения следующих задач:

б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
в) отсортировать список по возрасту студента;
г) * отсортировать список по курсу и возрасту студента;*/

    static class StudentsComparsion
    {
        public static void SortByFirstName(List<Student> students)
        {
            students.Sort((Student st1, Student st2) => (String.Compare(st1.firstName, st2.firstName)));
        }
        public static void SortByAge(List<Student> students)
        {
            students.Sort((Student st1, Student st2) => 
            {
                if (st1.age < st2.age)
                    return -1;
                else
                    return 1;
            }  
            );
        }

        public static void SortByCourseAndAge(List<Student> students)
        {
            students.Sort((Student st1, Student st2) =>
            {

                if (st1.course == st2.course)
                {
                    if (st1.age < st2.age)
                        return -1;
                    else
                        return 1;
                }
                else
                {
                    if (st1.course < st2.course)
                        return -1;
                    else
                        return 1;
                }
            }
            );
        }

    }
}
