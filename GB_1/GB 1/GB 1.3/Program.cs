using System;

namespace GB_1._3
{
    class Program
    {
        static double distance(double x1, double y1,double x2,double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main(string[] args)
        {
            /* Сиваченко Егор Александрович
            а) Написать программу, которая подсчитывает расстояние между точками с 
                координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
                Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            */

            double x1, y1, x2, y2, r;
            Console.Write("Введите x координату первой точки: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y координату первой точки: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x координату второй точки: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y координату второй точки: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            double result = distance(x1, y1, x2, y2);
            Console.WriteLine("Результатом программы является: {0:F2}",result);



        }

    }
}
