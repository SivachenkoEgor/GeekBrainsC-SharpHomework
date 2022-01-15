using System;
using System.Collections.Generic;
using System.IO;
using CallBackConsole;
using System.Threading;
using System.Diagnostics;

namespace GB_6._3
{
/*   
г) * отсортировать список по курсу и возрасту студента;*/
    class Program
    {
        static void Main(string[] args)
        {

            Exercise_Shower();

        }

        static void Exercise_Shower()
        {
            Stopwatch stopWatch = new();
            stopWatch.Start();

            // storage > list паттерн crud (паттерн репозиторий)
            List<Student> list = StudentGrabber.GetListFromFile("students_6.csv");
            
            ConsoleReporter reporter = new();

            reporter.ShowStudentCount(list);
            reporter.ShowBachelorsFromList(list);
            reporter.ShowMastersFromList(list);
            
            reporter.Show5thAnd6thCourseStudents(list);


            reporter.ShowAllStudents(list);



            StudentsComparsion.SortByFirstName(list);
            reporter.ShowAllStudents(list);
            StudentsComparsion.SortByAge(list);
            reporter.ShowAllStudents(list);

            foreach (var value in StudentsInfo.GetStudentsInAgeRange(list, 18, 20))
            {
                Console.WriteLine(value);
            }

            StudentsComparsion.SortByCourseAndAge(list);
            reporter.ShowAllStudents(list);


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine(String.Compare("дима", "вова"));

        }

    }
}
