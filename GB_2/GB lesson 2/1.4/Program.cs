using System;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сиваченко Егор Александрович
            //4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь,
            //если не прошел (Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу:
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.

            bool authorization()
            {

                string log = "root";
                string pass = "GeekBrains";
                int count = 3;
                do
                {
                    Console.Write("Введите логин: ");
                    string login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string password = Console.ReadLine();

                    if (login == log && password == pass)
                    {
                        Console.WriteLine("Вы успешно авторизовались.");
                        return true;
                    }
                    count--;
                    Console.WriteLine("Неправильный логин или пароль, осталось попыток: " + count);

                    
                } while (count > 0);
                Console.WriteLine("Попытки закончились.");
                return false;
                
            }

            authorization();
            
            
        }
    }
}
