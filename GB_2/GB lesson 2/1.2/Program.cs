using System;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сиваченко Егор Александрович
            //2. Написать метод подсчета количества цифр числа.

            double double_length(double num)
            {
                string result = Convert.ToString(num);
                num = result.Length;
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == ',') num--;

                }
                
                return num;
            }

        }
    }
}
