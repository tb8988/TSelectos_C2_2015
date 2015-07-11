using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabTopicos_app;

namespace Test_LabTopicos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Integral_Simple()
        {
            //Valores de prueba
            double var1 = 1;
            double var2 = 5;
            double result_esperado = 0;
            Integral integral = new Integral();


            //Accion
            result_esperado = integral.Simple(var1, var2);

            //Resultado
            double result_real = 4;
            Assert.AreEqual(result_esperado,result_real, 0.0001,"Resultado erroneo");

        }
    }
}
