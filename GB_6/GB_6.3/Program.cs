using System;
using System.Collections.Generic;
using System.IO;
using CallBackConsole;

namespace GB_6._3
{
/*    3. Переделать программу Пример использования коллекций для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    в) отсортировать список по возрасту студента;
г) * отсортировать список по курсу и возрасту студента;*/
    class Program
    {
        static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {

            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }

        static void Main(string[] args)
        {

            Exercise_Shower();

        }

        static void Exercise_Shower()
        {
            DateTime dt = DateTime.Now;
            List<Student> list = StudentGrabber.GetListFromFile("students_6.csv");
            StudentsInfo info = new();

            info.RegisterHandler(ConsoleView.CallBackConsole);

            info.StudentCount(list);
            info.GetBachelorsFromList(list);
            info.GetMastersFromList(list);


            StudentsComparsion.SortByFirstName(list);
            info.GetStudentsFirstNames(list);



            Console.WriteLine(DateTime.Now - dt);

        }

    }
}
