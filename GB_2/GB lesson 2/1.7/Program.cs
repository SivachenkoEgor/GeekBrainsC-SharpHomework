using System;

namespace _1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сиваченко Егор Александрович
            //7.
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

            void LoopA(int a, int b)
            {
                Console.Write("{0}  ", a);
                if (a < b) LoopA(a + 1, b);
            }

            int LoopB(int a, int b)
            {
                if (b == a)
                    return a;
                return LoopB(a, b-1) + b;


            }

            LoopA(5, 10);
            Console.WriteLine(LoopB(5, 10));

        }


    }
}
