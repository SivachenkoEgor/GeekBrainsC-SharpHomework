using System;

namespace _1._5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            void Print(string ms, int x, int y)
            {
                // не совсем понял - в задании указаны аргументы x,y, вероятно это про смещение курсора, тогда программа может смещать куда угодно, не только посередине.
                // вторым вариантом будет не указывать в аргументы метода x,y и задавать значение курсора через WinH и WinW.
                Console.SetCursorPosition(x, y);
                Console.WriteLine(ms);
            }
            /*  Сиваченко Егор Александрович
             *  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
                б) Сделать задание, только вывод организовать в центре экрана.
                в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
             */
            //a
            string name, lastName, city, text;

            Console.Write("Введите имя ");
            name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            lastName = Console.ReadLine();
            Console.Write("Введите город проживания ");
            city = Console.ReadLine();
            text = $"Имя: {name}, фамилия: {lastName}, город: {city}";
            Console.WriteLine(text);

            //б
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(text);

            // в

            Print(text, Console.WindowWidth / 2, Console.WindowHeight / 2);

        }
    }
}
