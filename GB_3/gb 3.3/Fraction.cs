using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gb_3._3
{
    /*
             * 3. * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей.
             *      Написать программу, демонстрирующую все разработанные элементы класса.
                    Добавить свойства типа int для доступа к числителю и знаменателю;
                    Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
                    ** Добавить проверку, чтобы знаменатель не равнялся 0.
                    Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
                    *** Добавить упрощение дробей.
            */
    class Fraction
    {
        public int Numerator { get; set; }

        private int denominator;

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                    throw new FractionException("Деление на ноль запрещено", value);
                else
                    denominator = value;


            }
        }


        public double DecimalFraction
        {
            get { return (double)Numerator / (double)Denominator; }

        }



        public Fraction(int numerator, int denominator)

        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public Fraction Sum(Fraction fr2)
        {
            int temp;
            Fraction frRes = new(Numerator, Denominator);
            temp = frRes.Denominator;
            frRes.Denominator *= fr2.Denominator;
            frRes.Numerator *= fr2.Denominator;
            fr2.Denominator *= temp;
            fr2.Numerator *= temp;
            frRes.Numerator += fr2.Numerator;
            return frRes = FractionReduction(frRes);
        }
        public Fraction Subtraction(Fraction fr2)
        {
            int temp;
            Fraction frRes = new(Numerator, Denominator);
            temp = frRes.Denominator;
            frRes.Denominator *= fr2.Denominator;
            frRes.Numerator *= fr2.Denominator;
            fr2.Denominator *= temp;
            fr2.Numerator *= temp;
            frRes.Numerator -= fr2.Numerator;
            return frRes = FractionReduction(frRes);

        }
        public Fraction Multi(Fraction fr2)
        {
            Fraction frRes = new(Numerator, Denominator);
            frRes.Numerator = fr2.Numerator * Numerator;
            frRes.Denominator = fr2.Denominator * Denominator;
            return frRes = FractionReduction(frRes);
        }
        public Fraction Div(Fraction fr2)
        {
            Fraction frRes = new(Numerator, Denominator);
            frRes.Numerator = fr2.Numerator * Denominator;
            frRes.Denominator = fr2.Denominator * Numerator;
            return frRes = FractionReduction(frRes);
        }
        private Fraction FractionReduction(Fraction fraction)
        {
            int a = fraction.Numerator;
            int b = fraction.Denominator;
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            fraction.Numerator /= (a + b);
            fraction.Denominator /= (a + b);

            return fraction;
        }
        public string ToSimple()
        {
            int res = 0;
            int numer = Numerator;
            int denom = Denominator;
            while (numer / denom >= 1)
            {
                res++;
                numer -= denom;
            }
            return res + " " + numer + "/" + denom;
        }

        override public string ToString()
        {
            return Numerator + "/" + Denominator;
        }
    }
}
