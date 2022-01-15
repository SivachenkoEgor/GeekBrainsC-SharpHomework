using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_6._4
{
    class FileOperations
    { /*   4. ** Считайте файл различными способами.Смотрите “Пример записи файла различными способами”.
        Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), 
 строку для StreamReader 
 и массив int для BinaryReader.*/
        public static byte[] FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();

            byte[] output = new byte[size];

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                output[i] = (Byte)fs.ReadByte();
            fs.Close();
            
            return output;
        }
        public static byte[] BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();

            byte[] output = new byte[size];

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);

            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                output[i] = (Byte)bw.ReadByte();
            fs.Close();

            return output;
        }
        public static string StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();

            string output = String.Empty;

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            //FileStream fs = new FileStream("D:\\temp\\bigdata.bin", FileMode.CreateNew, FileAccess.Write);
            for (int i = 0; i < size; i++)
                output += (Byte)fs.ReadByte();
            fs.Close();

            return output;
        }
        public static int[] BufferedStreamSample(string filename, long size, int countPart)
        {
            Stopwatch stopwatch = new Stopwatch();

            

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

          
            int[] output = new int[countPart];
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];

            BufferedStream bs = new BufferedStream(fs, bufsize);
            for (int i = 0; i < countPart; i++)
                output[i] = bs.Read(buffer, 0, (int)bufsize);
            fs.Close();

            return output;
        }



    }
}
