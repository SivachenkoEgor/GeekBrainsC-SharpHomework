using System;
using System.IO;
namespace GB_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Сиваченко Егор Александрович
             * 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
             * Создайте структуру Account, содержащую Login и Password.
             */
            void GetAccArr(string path, ref string[,] arr)
            {
                string[] lineArr = File.ReadAllLines(path);

                int row = lineArr.Length;
                int col = -1;
                for (int i = 0; i < lineArr.Length; i++)
                {
                    string[] line = lineArr[i].Split(new char[] { ' ', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (col == -1)
                    {
                        col = line.Length;
                        arr = new string[row, col];
                    }

                    for (int j = 0; j < line.Length; j++)
                    {
                        arr[i, j] = line[j];
                    }
                }

            }
            bool authorization(Account acc)
            {
                string log = "root";
                string pass = "GeekBrains";

                if (acc.login == log && acc.password == pass)
                    return true;
                return false;

            }
            void Print(string[,] mass)
            {
                for (int i = 0; i < mass.GetLength(0); i++)
                {
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        Console.WriteLine("{0,3}", mass[i, j]);
                    }
                    Console.WriteLine();
                }
            }




            string[,] arrAcc = new string[0, 0];
            string path = "acc file.txt";
            GetAccArr(path, ref arrAcc);
            Account acc1 = new("root","GeekBrains");
            Account acc2 = new(arrAcc[0, 0], arrAcc[0, 1]);
            Account acc3 = new(arrAcc[1, 0], arrAcc[1, 1]);
            Account acc4 = new(arrAcc[2, 0], arrAcc[2, 1]);

            Console.WriteLine($"Проверка авторизации: " +
                $"\n1: {authorization(acc1)}" +
                $"\n2: {authorization(acc2)}" +
                $"\n3: {authorization(acc3)}" +
                $"\n4: {authorization(acc4)}");









        }
    }
}
