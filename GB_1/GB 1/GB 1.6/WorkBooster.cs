using System;
using System.Collections.Generic;
using System.Text;

namespace GB_1._6
{
    class WorkBooster
    {


        
        // Сиваченко Егор Александрович
        // 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
        public void Print(string str)
        {
            Console.WriteLine(str);

    
            return;
        }

        public string StringMultiplier(string str, int multiplier)
        {
            string result = "";

            for (int i = 0; i < multiplier; i++)
            {
                result += str;
            }
            return result;
        }

        public void Pause()
        {
            Console.ReadKey();
        }

        public int ReadInt32()
        {
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }
    }

}
