using System;

namespace gb_3._1
{

    class Program
    {


        static void Main(string[] args)
        {
            /*
             * Сиваченко Егор Александрович
            1. 
            а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
            б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            в) Добавить диалог с использованием switch демонстрирующий работу класса.
            */

            int readNumRe1, readNumIm1, readNumRe2, readNumIm2, choice;
            do
            {
                Console.Write("Введите вещественную часть первого комплексного числа: ");
            } while (!int.TryParse(Console.ReadLine(), out readNumRe1));
            do
            {
                Console.Write("Введите мнимую часть первого комплексного числа: ");
            } while (!int.TryParse(Console.ReadLine(), out readNumIm1));
            do
            {
                Console.Write("Введите вещественную часть второго комплексного числа: ");
            } while (!int.TryParse(Console.ReadLine(), out readNumRe2));
            do
            {
                Console.Write("Введите мнимую часть второго комплексного числа: ");
            } while (!int.TryParse(Console.ReadLine(), out readNumIm2));
            bool flag;
            do
            {
                Console.Write("Введите номер желаемой операции: 1 для сложения, 2 для вычитания, 3 для произведения: ");
                flag = int.TryParse(Console.ReadLine(), out choice);
                if (choice < 1 || choice > 3) flag = false;

            } while (!flag);

            ComplexStruct number1, number2;
            number1.re = readNumRe1;
            number1.im = readNumIm1;
            number2.re = readNumRe2;
            number2.im = readNumIm2;
            ComplexClass num1 = new ComplexClass(readNumRe1, readNumIm1);
            ComplexClass num2 = new ComplexClass(readNumRe2, readNumIm2);
            switch (choice) // В
            {
                case 1: // A+Б
                    Console.Write("Сложение структур: ");
                    Console.WriteLine(number1.Plus(number2).ToString());
                    Console.Write("Сложение классов: ");
                    Console.WriteLine(num1.Plus(num2).ToString());
                    break;
                case 2: // A+Б
                    Console.Write("Вычитание структур: ");
                    Console.WriteLine(number1.Subtraction(number2).ToString());
                    Console.Write("Вычитание классов: ");
                    Console.WriteLine(num1.Subtraction(num2).ToString());
                    break;
                case 3: // A+Б
                    Console.Write("Произведение структур структур: ");
                    Console.WriteLine(number1.Multi(number2).ToString());
                    Console.Write("Произведение классов: ");
                    Console.WriteLine(num1.Multi(num2).ToString());
                    break;
                default:
                    Console.WriteLine("Вы промахнулись цифоркой");
                    break;
            }






        }
    }
}
