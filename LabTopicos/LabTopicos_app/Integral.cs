using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTopicos_app
{
    class Integral
    {

        public double Simple(int a, int b) {
            return (b-a);
        }
        public double Constante(int a, int b, int k) {
            return k * (b - a);
        }
        public double Potencia(int a, int b, int n){
            return ((Math.Pow(b, (n + 1)) / (n + 1)) - (Math.Pow(a, (n + 1)) / (n + 1)));
        }
        public double Logaritmo(int a, int b) {
            return (Math.Log10(b) - Math.Log10(a));
        }
        public double Exponencial(int a, int b) {
            return (Math.Pow(Math.E, b) - Math.Pow(Math.E, a));
        }
        public double Seno(int a, int b) {
            return ((-Math.Cos(b)) - (-Math.Cos(a)));
        }
        public double Coseno(int a, int b) {
            return ((Math.Sin(b)) - (Math.Sin(a)));
        }
    }
}
