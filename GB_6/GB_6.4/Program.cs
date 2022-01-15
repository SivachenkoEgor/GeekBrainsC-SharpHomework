using System;

namespace GB_6._4
{
 /*  Сиваченко Егор Александрович
  *  4. ** Считайте файл различными способами.Смотрите “Пример записи файла различными способами”.
        Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), 
 строку для StreamReader 
 и массив int для BinaryReader.*/
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var num in FileOperations.FileStreamSample("test_file", 16))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(new string('-', 50));
            foreach (var num in FileOperations.BinaryStreamSample("test_file", 16))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(new string('-', 50));

            Console.WriteLine(FileOperations.StreamWriterSample("test_file", 16));

            Console.WriteLine(new string('-', 50));
            foreach (var num in FileOperations.BufferedStreamSample("test_file", 16,4))
            {
                Console.WriteLine(num);
            }
        }
    }
}
