using System;

namespace DelegatesTestApp
{
    public delegate void Msg(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {

            SimpleMath math = new();

            math.RegisterHandler(CallBackConsole);
            math.RegisterHandler(CallBackForm);
            
            
            math.Add(5, 4);
            math.Sub(5, 4);
            math.Multi(5, 4);

            
            
        }

        static void CallBackConsole(string message)
        {
            Console.WriteLine(message);
        }
        static void CallBackForm(string message)
        {
            Console.WriteLine("Воображаемая форма");
            Console.WriteLine(message);
        }
    }
}
