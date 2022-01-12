using System;
using GB_4._5_Lib;
namespace GB_4._5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Сиваченко Егор александрович


            Arr2d arr1 = new(2, 5, 0, 21);
            Arr2d arr2 = new(2, 5, 0, 20);
            int[,] arr3 = new int[2, 5];
            Arr2d.ArrRandom(arr3, 0, 10);

            arr1.Print();
            arr2.Print();
            Arr2d.Print(arr3);

            Console.WriteLine(Arr2d.SumElems(arr3));
            Console.WriteLine(arr1.SumElems());
            Console.WriteLine(Arr2d.SumElems(arr3, 8));
            Console.WriteLine(arr1.SumElems(15));

            Console.WriteLine(arr1.MinElem);
            Console.WriteLine(arr1.MaxElem);
            int num1 = 0, num2 = 0;
            arr1.MaxElemNums(ref num1, ref num2);
            Console.WriteLine($"{num1}, {num2}");


            string path = "File with array.txt";
            Arr2d arr4 = new(path);
            arr4.Print();
            arr4.ArrayToFile(@"D:\VisualProjects\GB 4\GB 4.5\File with arr result.txt");

        }
    }
}
