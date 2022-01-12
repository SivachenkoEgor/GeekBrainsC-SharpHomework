using System;

namespace GB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Сиваченко Егор Александрович
             * 1. Написать программу «Анкета». Последовательно задаются 
             * вопросы (имя, фамилия, возраст, рост, вес). В результате вся 
             * информация выводится в одну строчку:
             */
            Console.Write("Введите имя ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию ");
            string lastName = Console.ReadLine(); ;
            Console.Write("Введите возраст ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите рост ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес ");
            double weight = Convert.ToDouble(Console.ReadLine());
            //a - склеивание
            Console.WriteLine("Имя: " + name + ", фамилия: " + lastName + ", возраст: "
                + age + ", рост: " + height + ", вес: " + weight);
            //б - форматированный вывод
            Console.WriteLine("Имя: {0},фамилия: {1},возраст: {2}," +
                "рост: {3},вес: {4}", name, lastName, age, height, weight);
            //в - интерполяция
            Console.WriteLine($"Имя: {name}, фамилия: {lastName},возраст: {age}," +
                $"рост: {height},вес: {weight}");
        }
    }
}
