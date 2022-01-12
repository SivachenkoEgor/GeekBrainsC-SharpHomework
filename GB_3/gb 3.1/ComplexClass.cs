using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gb_3._1
{
    class ComplexClass
    {

        public double Im { get; set; }
        public double Re { get; set; }
        public ComplexClass(double re, double im)
        {
            Re = re;
            Im = im;
        }
        // сложение
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass(Re, Im);
            x3.Im = x2.Im + Im;
            x3.Re = x2.Re + Re;
            return x3;
        }
        // произведение
        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass(Re, Im);
            x3.Im = Re * x2.Im + Im * x2.Re;
            x3.Re = Re * x2.Re - Im * x2.Im;
            return x3;
        }
        // вычитание
        public ComplexClass Subtraction(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass(Re, Im);
            x3.Im = x2.Im - Im;
            x3.Re = x2.Re - Re;
            return x3;
        }


        public string ToString()
        {
            return Re + "+" + Im + "i";
        }

    }
}
