using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Mathematiques : IMathematiques
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Soustraction(double x, double y)
        {
            return x - y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double Division(double x, double y)
        {
            return x / y;
        }
    }
}
