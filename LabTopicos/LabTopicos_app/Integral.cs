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
            return ((Math.Pow(b, 2) / 2) - (Math.Pow(a, 2) / 2));
        }
        public double Constante(int a, int b, int k) {
            return k * (b - a);
        }
        public void Potencia(int a, int b, int n){

        }
        public void Logaritmo(int a, int b) { 
            //Math.Log()
        }
        public void Exponencial(int a, int b) {
            double e = Math.E;
        }
        public void Seno(int a, int b) { 
            //Math.Sin()
        }
        public void Coseno(int a, int b) { 
            //Math.Cos()
        }
    }
}
