using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            static long RecursiveSum(long a)                    // рекурсивный метод
            {
                if (a == 0)                                  // если a =0
                    return 0;                              // возвращаем 0
                else return RecursiveSum(a / 10) + a % 10;   // иначе вызываем рекурсивно сами себя
            }

            Console.WriteLine(RecursiveSum(101));



        }
    }
}
