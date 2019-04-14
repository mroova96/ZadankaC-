using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                string text;
                Console.Write("Podaj wartosc dzielnej (a): ");
                text = Console.ReadLine();
                Int32.TryParse(text, out a);
                Console.Write("Podaj wartosc dzielnika (b): ");
                text = Console.ReadLine();
                Int32.TryParse(text, out b);

                Console.WriteLine("Wynik dzielnia: {0} ", a / b);


            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nigdy cholero niedziel przez zero");
            }


            Console.ReadKey();
        }
    }
}
