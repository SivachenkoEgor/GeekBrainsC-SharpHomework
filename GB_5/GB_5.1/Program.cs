using System;
using System.Text.RegularExpressions;

namespace GB_5._1
{
    class Program
    {
        /*1. Создать программу, которая будет проверять корректность ввода логина.
         * Корректным логином будет строка от 2 до 10 символов,
        * содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        а) без использования регулярных выражений;
        б) **с использованием регулярных выражений.*/

        static void Main(string[] args)
        {


            bool IsLatinString(string str)
            {
                bool result = true;
                for (int c = 0; c < str.Length;c++)
                {
                    if (!Char.IsDigit(str[c]))
                    {
                        if ((str[c] >= 'a' && str[c] <= 'z') || (str[c] >= 'A' && str[c] <= 'Z'))
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                   
                }
                return result;
            }

            bool Acc_Check_NoRegex(string login)
            {
                bool result = false;
                if (login.Length >= 2 && login.Length <= 10 && !Char.IsDigit(login[0]) && IsLatinString(login))
                {
                    result = true;
                }

                return result;
            }

            bool Acc_Check_Regex(string login)
            {
                Regex myReg = new(@"^(?=.{2,10}$)[a-zA-Z][0-9a-zA-Z]*");
                return myReg.IsMatch(login);
            }

            void Exercise_Shower()
            {
                
                string[] logins = new[] { "hellO45k7s", "1hellonehr", "привет" , "g" };
                foreach(string word in logins)
                {
                    Console.WriteLine("Логин: " + word);
                    Console.WriteLine("Без регулярных выражений: " + Acc_Check_NoRegex(word));
                    Console.WriteLine("С регулярными выражениями: " + Acc_Check_Regex(word));
                }

            }

            Exercise_Shower();



        }
    }
}
