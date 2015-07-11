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
            String mensaje;
            try
            {
                if (a < b)
                {
                    return (b - a);
                }
                else
                {
                    mensaje = ("a debe ser menor a b");
                    return 0;
                }
            }
            catch (ArgumentException e)
            {
                mensaje = "a y b deben ser numeros enteros diferentes a cero";
                return 0;
            }

        }
        public double Constante(double a, double b, double k)
        {
            String mensaje;
            try
            {
                if (a < b)
                {
                    return k * (b - a);
                }
                else
                {
                    mensaje = "a debe ser menor a b";
                    return 0;
                }
            }
            catch (ArgumentException e)
            {
                mensaje = "a y b deben ser numeros enteros diferentes a cero";
                return 0;
            }
        }
        public double Potencia(double a, double b, double n)
        {
            String mensaje;
            try
            {
                if (a < b)
                {
                    return ((Math.Pow(b, (n + 1)) / (n + 1)) - (Math.Pow(a, (n + 1)) / (n + 1)));
                }
                else
                {
                    mensaje = "a debe ser menor a b";
                    return 0;
                }
            }
            catch (ArgumentException e)
            {
                mensaje = "a y b deben ser numeros enteros diferentes a cero";
                return 0;
            }
        }
        public double Logaritmo(double a, double b)
        {
            String mensaje;
            try
            {
                if (a < b)
                {
                    return (Math.Log(b, Math.E) - Math.Log(a, Math.E));
                }
                else
                {
                    mensaje = "a debe ser menor a b";
                    return 0;
                }
            }
            catch (ArgumentException e)
            {
                mensaje = "a y b deben ser numeros enteros diferentes a cero";
                return 0;
            }
        }
        public double Exponencial(double a, double b)
        {
            String mensaje;
            try
            {
                if (a < b)
                {
                    return (Math.Pow(Math.E, b) - Math.Pow(Math.E, a));
                }
                else
                {
                    mensaje = "a debe ser menor a b";
                    return 0;
                }
            }
            catch (ArgumentException e)
            {
                mensaje = "a y b deben ser numeros enteros diferentes a cero";
                return 0;
            }
        }
        public double Seno(double a, double b)
        {
            String mensaje;
            try
            {
                if (a < b)
                {
                    return ((-Math.Cos(b)) - (-Math.Cos(a)));
                }
                else
                {
                    mensaje = "a debe ser menor a b";
                    return 0;
                }
            }
            catch (ArgumentException e)
            {
                mensaje = "a y b deben ser numeros enteros diferentes a cero";
                return 0;
            }
        }
        public double Coseno(double a, double b)
        {
            String mensaje;
            try
            {
                if (a < b)
                {
                    return ((Math.Sin(b)) - (Math.Sin(a)));
                }
                else
                {
                    mensaje = "a debe ser menor a b";
                    return 0;
                }
            }
            catch (ArgumentException e)
            {
                mensaje = "a y b deben ser numeros enteros diferentes a cero";
                return 0;
            }
        }
    }
}
