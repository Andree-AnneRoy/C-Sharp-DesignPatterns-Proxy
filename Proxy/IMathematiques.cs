using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IMathematiques
    {
        double Addition(double x, double y);
        double Soustraction(double x, double y);
        double Multiplication(double x, double y);
        double Division(double x, double y);
    }
}
