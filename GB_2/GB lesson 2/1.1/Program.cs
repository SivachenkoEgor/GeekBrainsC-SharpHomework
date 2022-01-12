using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сиваченко Егор Александрович
            // 1. Написать метод, возвращающий минимальное из трёх чисел.
            double min (double k, double y, double s)
            {
                double result;
                if (k < y && k < s) return k;
                else if (y < k && y < s) return y;
                else if (s < k && s < y) return s;
                else return k;
            }
            
      
        }
    }
}
