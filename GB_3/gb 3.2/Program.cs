using System;

namespace gb_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Сиваченко Егор Александрович
             * 2.
            а) С клавиатуры вводятся числа, пока не будет введён 0 
            (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел.
            Сами числа и сумму вывести на экран, используя tryParse.
            */
            int readNum,sum = 0;
            do
            {
                Console.Write("Введите число: ");
                int.TryParse(Console.ReadLine(), out readNum);
                if (readNum > 0 && readNum % 2 == 1)
                {
                    sum += readNum;
                }
            }
            while (readNum != 0);
            Console.WriteLine($"Сумма нечетных положительных чисел равна {sum}");
        }
    }
}
