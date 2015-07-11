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

        [TestMethod]
        public void Test_Integral_Constante()
        {
            //Valores de prueba
            double var1 = 2;
            double var2 = 4;
            double constante = 3;
            double result_esperado = 0;
            Integral integral = new Integral();

            //Accion
            result_esperado = integral.Constante(var1, var2, constante);

            //Validacion
            double result_real = 6;
            Assert.AreEqual(result_esperado, result_real, 0.0001, "Resultado erroneo integral con constante");

        }

        [TestMethod]
        public void Test_Integral_Potencia()
        {
            //Variables de Prueba
            double var1 = 4;
            double var2 = 6;
            double pow = 2;
            double result_esperado = 0;
            Integral integral = new Integral();

            //Accion
            result_esperado = integral.Potencia(var1, var2, pow);

            //Validacion
            double result_real = 50.66667;
            Assert.AreEqual(result_esperado, result_real, 0.0001, "Resultado erroneo integral con potencia");
        }

        [TestMethod]
        public void Test_Integral_Log()
        {
            //Valores de prueba
            double var1 = 5;
            double var2 = 8;
            double result_esperado = 0;
            Integral integral = new Integral();

            //Accion
            result_esperado = integral.Logaritmo(var1, var2);

            //Validacion
            double result_real = 2.42699;
            Assert.AreEqual(result_esperado, result_real, 0.0001, "Resultado erroneo integral comn logaritmo");

        }


        [TestMethod]
        public void Test_Integral_Expo()
        {
            //Valores de prueba
            double var1 = 9;
            double var2 = 2;
            double result_esperado = 0;
            Integral integral = new Integral();

            //Accion
            result_esperado = integral.Exponencial(var1, var2);

            //Validacion
            double result_real = 34.51261;
            Assert.AreEqual(result_esperado, result_real, 0.0001, "Resultado erroneo integral exponencial");

        }

        [TestMethod]
        public void Test_Integral_Sen()
        {
            //Valores de prueba
            double var1 = 3;
            double var2 = 4;
            double result_esperado = 0;
            Integral integral = new Integral();

            //Accion
            result_esperado = integral.Seno(var1, var2);

            //Validacion
            double result_real = -0.33635;
            Assert.AreEqual(result_esperado, result_real, 0.0001, "Resultado erroneo integral con seno");
        }

        [TestMethod]
        public void Test_Integral_Cos()
        {
            //Valores de prueba
            double var1 = 2;
            double var2 = 5;
            double result_esprado = 0;
            Integral integral = new Integral();

            //Accion
            result_esprado = integral.Coseno(var1, var2);

            //Validacion
            double result_real = -1.86822;
            Assert.AreEqual(result_esprado, result_real, 0.0001, "Resultado erroneo integral con coseno");
        }
    }
}
