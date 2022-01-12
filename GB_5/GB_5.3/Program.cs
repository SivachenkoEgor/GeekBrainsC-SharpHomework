using System;

namespace GB_5._3
{
    class Program
    {
        /*  3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
              Например: badc являются перестановкой abcd.*/
        static void Main(string[] args)
        {
            bool isRearranged(string stringA, string stringB)
            {

                if (stringA.Length == stringB.Length)
                {
                    for (int i = 0; i < stringA.Length; i++)
                    {
                        if (stringB.Contains(stringA[i]))
                            continue;
                        else
                            return false; ;
                    }
                    return true;
                }
                else
                {
                    throw new Exception("Строки имеют разную длину");
                }
            }

            void ExerciseShower()
            {
                string a = "abcd";
                string b = "bacd";
                string c = "abcc";
                string d = "abccd";
                Console.WriteLine(isRearranged(a, b));
                Console.WriteLine(isRearranged(a, c));
                Console.WriteLine(isRearranged(a, d));
            }

            ExerciseShower();
        }
    }
}
