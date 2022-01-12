using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сиваченко Егор Александрович
            //3. С клавиатуры вводятся числа, пока не будет введен 0.
            //Подсчитать сумму всех нечетных положительных чисел.
            int input;
            int sum = 0;
            
            do
            {
                Console.Write("Введите число: ");
                int.TryParse(Console.ReadLine(), out input);
                if (-input % 2 == 1 && input < 0) sum++;
            }
            while (input != 0);
            Console.WriteLine("Количество нечетных отрицательных чисел: " + sum);
        }
    }
}
