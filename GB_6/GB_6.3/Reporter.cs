using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_6._3
{
    abstract class Reporter
    {
        public abstract void ShowStudentCount(List<Student> list);
        public abstract void ShowBachelorsFromList(List<Student> list);
        public abstract void ShowMastersFromList(List<Student> list);
        public abstract void ShowStudentsFirstNames(List<Student> list);
        public abstract void Show5thAnd6thCourseStudents(List<Student> list);
        public abstract void ShowAllStudents(List<Student> list);

    }

    class ConsoleReporter : Reporter
    {
        public override void ShowStudentCount(List<Student> list)
        {
            Console.WriteLine("Количество студентов: ");
            Console.WriteLine(StudentsInfo.StudentCount(list));
        }

        public override void ShowBachelorsFromList(List<Student> list)
        {
            Console.WriteLine("Количество бакалавров: ");
            Console.WriteLine(StudentsInfo.GetBachelorsFromList(list));
        }

        public override void ShowMastersFromList(List<Student> list)
        {
            Console.WriteLine("Количество магистров: ");
            Console.WriteLine(StudentsInfo.GetMastersFromList(list));
        }

        public override void ShowStudentsFirstNames(List<Student> list)
        {
            Console.WriteLine("Имена студентов после сортировки: ");
            foreach (var name in StudentsInfo.GetStudentsFirstNames(list))
            {
                Console.WriteLine(name);
            }
        }

        public override void Show5thAnd6thCourseStudents(List<Student> list)
        {
            Console.WriteLine("Имена студентов 5 и 6 курсов");
            foreach (var student in StudentsInfo.Get5thAnd6thCourseStudents(list))
            {
                Console.WriteLine(student.firstName);
            }
        }


        public override void ShowAllStudents(List<Student> list)
        {
            Console.WriteLine("Все студенты: ");
            foreach (var student in list)
            {
                foreach (var field in student.GetType()
                     .GetFields()
                     .Select(field => field.GetValue(student))
                     .ToList())
                {
                    Console.Write("{0,10:0.000} ", field.ToString());
                }
                Console.WriteLine();
            }

        }
    }
}
