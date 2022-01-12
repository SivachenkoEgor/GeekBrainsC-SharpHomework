using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GB_4._2
{



    class Program
    {
        static void Main(string[] args)
        {

            /* Сиваченко Егор Александрович
             * 2. Реализуйте задачу 1 в виде статического класса StaticClass;
            а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            в)*Добавьте обработку ситуации отсутствия файла на диске.
            */

            // a
            int[] arr = new int[20];
            ArrOperation.ArrRandRange(arr, -10000, 10001);
            Console.WriteLine(ArrOperation.PairMod(arr, 3));
            // б
            string path = "File with array.txt";
            int[,] arrB = ArrOperation.ArrFromFile(path);

            ArrOperation.Print(arrB);






        }
    }
}
