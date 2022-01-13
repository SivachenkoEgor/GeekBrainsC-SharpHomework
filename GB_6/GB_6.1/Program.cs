using System;

namespace GB_6._1
{
    /* Сиваченко Егор Александрович
     * 1. Изменить программу вывода таблицы функции так,
            чтобы можно было передавать функции типа double (double, double).
            Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).*/

    public delegate double MathOperations(double a, double x);

    class Program
    {
        // таблица
        public static void Table(MathOperations F,double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a,x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // произведение квадрата  и числа
        public static double MultedSquare(double a,double x)
        {
            return a * x * x;
        }
        // Произведение синуса и числа
        public static double MultedSin(double a,double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            Table(MultedSquare, 2, -2, 2);
            Table(MultedSin, 5, -2, 2);

        }
    }

}