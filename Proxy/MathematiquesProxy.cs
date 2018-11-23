using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class MathematiquesProxy : IMathematiques
    {
        private Mathematiques maths = new Mathematiques();

        public double Addition(double x, double y)
        {
            return maths.Addition(x, y);
        }

        public double Soustraction(double x, double y)
        {
            return maths.Soustraction(x, y);
        }

        public double Multiplication(double x, double y)
        {
            return maths.Multiplication(x, y);
        }

        public double Division(double x, double y)
        {
            return maths.Division(x, y);
        }
    }
}
