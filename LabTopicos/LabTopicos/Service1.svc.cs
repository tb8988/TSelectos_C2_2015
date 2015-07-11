using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LabTopicos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public double CalculaIntegrales(double a, double b, double c, double Constante, int operacion) 
        {
            /* Valores de operacion
             * 1 = Simple
             * 2 = Constante
             * 3 = Potencia
             * 4 = Logaritmo
             * 5 = Exponencial
             * 6 = Seno
             * 7 = Coseno
             * */
            LabTopicos_app.Integral Calc = new LabTopicos_app.Integral();

            if (operacion == 1)
            {
                return Calc.Simple(a, b);
            }
            else if (operacion == 2)
            {
                return Calc.Constante(a, b, Constante);
            }
            else if (operacion == 3) 
            {
                return Calc.Potencia(a, b, c);
            }
            else if (operacion == 4) 
            {
                return Calc.Logaritmo(a, b);
            }
            else if (operacion == 5) 
            {
                return Calc.Exponencial(a, b);
            }
            else if (operacion == 6) 
            {
                return Calc.Seno(a, b);
            }
            else if (operacion == 7) 
            {
                return Calc.Coseno(a, b);
            }

            return 0;
        }


       /* public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
    }
}
