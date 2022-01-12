using System;
using System.IO;
using System.Text;

namespace GB_4._5_Lib
{
    /*
    // а) Реализовать библиотеку с классом для работы с двумерным массивом. 

    * Реализовать конструктор, заполняющий массив случайными числами. 
    * 
    * Создать методы, которые
    * 
    * возвращают сумму всех элементов массива, 
    * 
    * сумму всех элементов массива больше заданного,

    * свойство, возвращающее минимальный элемент массива,

    * свойство, возвращающее максимальный элемент массива, 
    * 
    * метод, возвращающий номер максимального элемента массива 
    * 

    * (через параметры, используя модификатор ref или out).
    * 
    *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    *
    **в) Обработать возможные исключительные ситуации при работе с файлами.
*/
    public class Arr2d
    {
        public int[,] Arr { get; set; }

        public int MinElem
        {
            get
            {
                int min = this.Arr[0, 0];
                for (int i = 0; i < this.Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < this.Arr.GetLength(1); j++)
                    {
                        if (this.Arr[i, j] < min)
                            min = this.Arr[i, j];
                    }
                }
                return min;
            }
        }

        public int MaxElem
        {
            get
            {
                int max = this.Arr[0, 0];
                for (int i = 0; i < this.Arr.GetLength(0); i++)
                {
                    for (int j = 0; j < this.Arr.GetLength(1); j++)
                    {
                        if (this.Arr[i, j] > max)
                            max = this.Arr[i, j];
                    }
                }
                return max;
            }
        }

        public void MaxElemNums(ref int maxNum1, ref int maxNum2)
        {
            int max = this.Arr[0, 0];

            for (int i = 0; i < this.Arr.GetLength(0); i++)
            {
                for (int j = 0; j < this.Arr.GetLength(1); j++)
                {
                    if (this.Arr[i, j] > max)
                    {
                        max = this.Arr[i, j];
                        maxNum1 = i;
                        maxNum2 = j;
                    }

                }
            }

        }
        public Arr2d(int dim0, int dim1)
        {

            this.Arr = new int[dim0, dim1];
            Random rnd = new();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    this.Arr[i, j] = rnd.Next();
                }
            }
        }

        public Arr2d(int dim0, int dim1, int from, int to)
        {

            this.Arr = new int[dim0, dim1];
            Random rnd = new();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    this.Arr[i, j] = rnd.Next(from, to);
                }
            }
        }

        public Arr2d(string path)
        {
            bool flag = false;
            do
            {
                try
                {
                    flag = false;
                    File.ReadAllLines(path);

                }
                catch
                {
                    Console.WriteLine("Такого файла нет, введите корректный путь до файла: ");
                    path = Console.ReadLine();
                    flag = true;

                }
            } while (flag);

            string[] lineArr = File.ReadAllLines(path);
            Arr = new int[0, 0];
            int row = lineArr.Length;
            int col = -1;
            for (int i = 0; i < lineArr.Length; i++)
            {
                string[] line = lineArr[i].Split(new char[] { ' ', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (col == -1)
                {
                    col = line.Length;
                    Arr = new int[row, col];
                }

                for (int j = 0; j < line.Length; j++)
                {
                    Arr[i, j] = Int32.Parse(line[j]);
                }
            }
        }

        public static int SumElems(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            return sum;
        }
        public static int SumElems(int[,] arr, int from)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > from)
                        sum += arr[i, j];
                }
            }
            return sum;
        }
        public int SumElems()
        {
            int sum = 0;
            for (int i = 0; i < this.Arr.GetLength(0); i++)
            {
                for (int j = 0; j < this.Arr.GetLength(1); j++)
                {
                    sum += this.Arr[i, j];
                }
            }
            return sum;
        }
        public int SumElems(int from)
        {
            int sum = 0;
            for (int i = 0; i < this.Arr.GetLength(0); i++)
            {
                for (int j = 0; j < this.Arr.GetLength(1); j++)
                {
                    if (this.Arr[i, j] > from)
                        sum += this.Arr[i, j];
                }
            }
            return sum;
        }

        public static void ArrRandom(int[,] arr)
        {
            Random rnd = new();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next();
                }
            }
        }
        public static void ArrRandom(int[,] arr, int from, int to)
        {
            Random rnd = new();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(from, to);
                }
            }
        }

        
        public void ArrayToFile(string path)
        {
            string str = string.Empty;
            for (int i = 0; i < this.Arr.GetLength(0); i++)
            {
                for (int j = 0; j < this.Arr.GetLength(1); j++)
                {
                    str += Convert.ToString(this.Arr[i, j]);
                }
            }

            Console.WriteLine(str);
            File.WriteAllText("File with arr result.txt", str);

        }
        public void Print()
        {
            int row = this.Arr.GetLength(0);
            int col = this.Arr.GetLength(1);
            Console.WriteLine("____________\n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{this.Arr[i, j],3} ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("\n____________");
        }
        public static void Print(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            Console.WriteLine("____________\n");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arr[i, j],3} ");
                }

                Console.WriteLine();
            }
            Console.WriteLine("\n____________");
        }



    }
}
