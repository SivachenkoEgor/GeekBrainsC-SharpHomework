using System;

namespace GB_4._1
{
    class Program

    {

        static void Main(string[] args)
        {
            /* Сиваченко Егор Алекандрович
             * 1. Дан целочисленный массив из 20 элементов. 
             * Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
             * Заполнить случайными числами. Написать программу, позволяющую найти 
             * и вывести количество пар элементов массива,
             * в которых только одно число делится на 3. В данной задаче под парой
             * подразумевается два подряд идущих элемента массива.
             * */
      
            int PairMod(int[] arr, int mod)
            {
                int sum = 0;

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] % mod == 0 && arr[i - 1] % mod != 0)
                        sum++;
                    else if (arr[i - 1] % mod == 0 && arr[i] % mod != 0)
                        sum++;
                }
                return sum;

            }
            void ArrRandRange(int[] arr, int from, int to)
            {
                Random random = new();
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = random.Next(from, to );
            }




            int[] arr = new int[20];
            ArrRandRange(arr, -10000, 10001);



            Console.WriteLine(PairMod(arr,3));












        }
    }
}
