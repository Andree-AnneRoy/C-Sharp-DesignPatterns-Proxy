using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MathematiquesProxy proxy = new MathematiquesProxy();

            Console.WriteLine("Addition : 10 + 5 = " + proxy.Addition(10,5));
            Console.WriteLine("Soustraction : 10 - 5 = " + proxy.Soustraction(10, 5));
            Console.WriteLine("Multiplication : 10 * 5 = " + proxy.Multiplication(10, 5));
            Console.WriteLine("Division : 10 / 5 = " + proxy.Division(10, 5));

            Console.ReadKey();
        }
    }
}
