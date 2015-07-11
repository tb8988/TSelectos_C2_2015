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

        public void CalculaIntegrales(double a, double b, double c, string Constante, int operacion) 
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

            if(operacion == 1)
            {
            LabTopicos_app.Integral Integ = new LabTopicos_app.Integral();
            Integ.Simple()
            }
            
        
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
