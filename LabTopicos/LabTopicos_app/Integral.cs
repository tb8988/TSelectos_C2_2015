using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTopicos_app
{
    public class Integral
    {

        public double Simple(double a, double b)
        {
            return (b-a);
        }
        public double Constante(double a, double b, double k)
        {
            return k * (b - a);
        }
        public double Potencia(double a, double b, double n)
        {
            return ((Math.Pow(b, (n + 1)) / (n + 1)) - (Math.Pow(a, (n + 1)) / (n + 1)));
        }
        public double Logaritmo(double a, double b)
        {
            return (Math.Log10(b) - Math.Log10(a));
        }
        public double Exponencial(double a, double b)
        {
            return (Math.Pow(Math.E, b) - Math.Pow(Math.E, a));
        }
        public double Seno(double a, double b)
        {
            return ((-Math.Cos(b)) - (-Math.Cos(a)));
        }
        public double Coseno(double a, double b)
        {
            return ((Math.Sin(b)) - (Math.Sin(a)));
        }
    }
}
