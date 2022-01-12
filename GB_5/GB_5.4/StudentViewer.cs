using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace GB_5._4
{
    // Сиваченко Егор Александрович
    /* 4. *Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, 
каждая из следующих N строк имеет следующий формат:

<Фамилия> <Имя> <оценки>,
где
<Фамилия> — строка, состоящая не более чем из 20 символов, 
<Имя> — строка, состоящая не более чем из 15 символов,
<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
<Фамилия> и <Имя>, а также <Имя> и<оценки> разделены одним пробелом. Пример входной строки:


 Иванов Петр 4 5 3
 Требуется написать как можно более эффективную программу,
которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших,
следует вывести и их фамилии и имена.*/
    struct Student
    {
        public string name;
        public string lastName;
        public float averageScore;

    }

    static class StudentViewer
    {
        public static string[] GetResult(string[] input)
        {
            IsCorrectSheet(input);
            Student[] students = ToStudent(input);
            students = students.OrderBy(i => i.averageScore).ToArray();
            int listCount = 3; // длина выходного списка, при одинаковых плохих оценках список будет увеличиваться, нужна для определения размера выходного массива
            for (int i = 3; i < students.Length; i++)
            {
                if (students[i].averageScore == students[i - 1].averageScore)
                    listCount++;
                else
                    break;

            }
            string[] output = new string[listCount];

            for (int i = 0; i < 3; i++)
                output[i] = students[i].name + " " + students[i].lastName + " " + students[i].averageScore.ToString();

            for (int i = 3; i < listCount; i++)
            {
                if (students[i].averageScore == students[i - 1].averageScore)
                    output[i] = students[i].name + " " + students[i].lastName + " " + students[i].averageScore.ToString();

            }



            return output;
        }

        static void IsCorrectSheet(string[] input)
        {

            bool success = byte.TryParse(input[0], out byte studentsCount);
            if (!success)
                throw new Exception("Число учеников задано некорректно");
            if (Convert.ToInt32(studentsCount) < 10 || Convert.ToInt32(studentsCount) > 100)
                throw new Exception("Введено неправильное количество учеников");
            if (input.Length - 1 != studentsCount)
                throw new Exception("Количество учеников не соответствует заявленному числу");

            Regex myReg = new(@"[а-яА-Яa-zA-Z]{1,20} [а-яА-Яa-zA-Z]{1,15} [2-5] [2-5] [2-5]");

            for (int i = 1; i < input.Length; i++)
            {
                if (!myReg.IsMatch(input[i]))
                    throw new Exception("Формат строки задан неверно");


            }
        }
        static Student[] ToStudent(string[] input)
        {
            Student[] output = new Student[input.Length - 1];
            string[] currentStudent;
            for (int i = 1; i < input.Length; i++)
            {
                currentStudent = input[i].Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries);
                float scoreSum = (Convert.ToInt32(currentStudent[2]) + Convert.ToInt32(currentStudent[3]) + Convert.ToInt32(currentStudent[4])) / 3f;
                output[i - 1].name = currentStudent[0];
                output[i - 1].lastName = currentStudent[1];
                output[i - 1].averageScore = scoreSum;
            }
            return output;
        }


    }
}
