using System;

namespace GB_1._6
{
    class Program
    {

        static void Main(string[] args)
        {
            // Сиваченко Егор Александрович
            // 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
            WorkBooster workBooster = new WorkBooster();
            
            workBooster.Print("hello");
            workBooster.Print("press enter to continue");
            workBooster.Pause();
            workBooster.Print("Введите текст, который желаете умножить");
            string text = Console.ReadLine();
            workBooster.Print("На какое число вы хотите умножить данный текст?");
            int multiplier = workBooster.ReadInt32();
            workBooster.Print("Результат: " + workBooster.StringMultiplier(text,multiplier));

            



        }
    }
}
