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


    static class StudentsInfo
    {

        public static int StudentCount(List<Student> students)
        {
            return students.Count;
        }


        public static int GetBachelorsFromList(List<Student> students)
        {
            int bachelorCount = 0;
            foreach (var student in students)
                if (student.course < 5) bachelorCount++;


            return bachelorCount;
        }


        public static int GetMastersFromList(List<Student> students)
        {
            int masterCount = 0;
            foreach (var student in students)
                if (student.course >= 5) masterCount++;
            return masterCount;
        }
        public static string[] GetStudentsFirstNames(List<Student> students)
        {
            string[] firstNames = new string[students.Count];

            for (int i = 0; i < students.Count; i++)
            {
                firstNames[i] = students[i].firstName;
            }
            return firstNames;

        }

        public static List<Student> Get5thAnd6thCourseStudents(List<Student> students)
        {
            List<Student> outputList = new();

            foreach (var student in students)
            {
                
                if (student.course == 5 || student.course == 6)
                {
                    outputList.Add(student);
                }
                    
            }
            
            return outputList;
        }

        public static Dictionary<int,int> GetStudentsInAgeRange(List<Student> students, int from, int to)
        {

            Dictionary<int, int> output = new();

            foreach (var student in students)
            {
                if (student.age >= from && student.age <= to)
                {
                    if (output.ContainsKey(student.age))
                        output[student.age]++;
                    else
                        output.Add(student.age, 1);                }
            }



            return output;
        }

    }
}
