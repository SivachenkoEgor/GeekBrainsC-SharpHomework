using System;

namespace gb_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Сиваченко Егор Александрович
             * 3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей.
             *      Написать программу, демонстрирующую все разработанные элементы класса.
                    Добавить свойства типа int для доступа к числителю и знаменателю;
                    Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
                ** Добавить проверку, чтобы знаменатель не равнялся 0.
                    Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); *** Добавить упрощение дробей.
            */
            /*
            Fraction num1 = new (5, 10);
            Fraction num2 = new (6, 10);

            Fraction res = num1.Sum(num2); // сумма
            Console.WriteLine(res.ToString());
            res = num1.Subtraction(num2);// вычитание
            Console.WriteLine(res.ToString());
            res = num1.Multi(num2);// умножение
            Console.WriteLine(res.ToString());
            res = num1.Div(num2);// деление
            Console.WriteLine(res.ToString());
            //Fraction num3 = new(5, 0); - тут выбрасывает экспешнн
            Console.WriteLine(res.ToSimple()); // упрощенная форма
            Console.WriteLine(res.DecimalFraction); // десятичная форма
            */


            Drobi pervayadrob = new ();

            pervayadrob.chislitel = 5;
            pervayadrob.znamenatel = 10;

            Drobi vtorayadrob = new();
            vtorayadrob.chislitel = 3;
            vtorayadrob.znamenatel = 10;

            Drobi res = new();
            res = res.Sum(pervayadrob, vtorayadrob);
            Console.WriteLine(res.ToString());






        }
    }
}
