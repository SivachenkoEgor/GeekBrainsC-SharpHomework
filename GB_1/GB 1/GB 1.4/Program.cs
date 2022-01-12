using System;

namespace GB_1._4
{
    class Program
    {
        /*
         *  Сиваченко Егор Александрович
            4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            а) с использованием третьей переменной;
            б) *без использования третьей переменной.
         */
        static void Main(string[] args)
        {
            // a
            {
                int num1, num2, num3;
                num1 = 5;
                num2 = 2;
                num3 = num2;
                num2 = num1;
                num1 = num3;
                Console.WriteLine("num1 {0},num2 {1}", num1, num2);
            }
            // b
            {
                int num1, num2;
                num1 = 5;
                num2 = 2;
                num1 += num2;
                num2 = num1 - num2;
                num1 -= num2;
                Console.WriteLine("num1 {0},num2 {1}", num1, num2);
            }

        }
    }
}
