using System;

namespace _1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сиваченко Егор Александрович
            //6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
            //«Хорошим» называется число, которое делится на сумму своих цифр.
            //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            DateTime StartTime;
            StartTime = DateTime.Now;
            int goodNumsCount = 0;

            for (int i = 1; i <= 1000000000; i++)
            {
                int sum = 0;
                int j = i;
                Console.WriteLine(j);
                while (j != 0)
                {
                    sum += j % 10;
                    j /= 10;
                }
                if (i % sum == 0) goodNumsCount++;
            }
            Console.WriteLine(goodNumsCount);

            DateTime EndTime = DateTime.Now;
            Console.WriteLine("Время работы программы : " + (EndTime - StartTime));


        }
    }
}
