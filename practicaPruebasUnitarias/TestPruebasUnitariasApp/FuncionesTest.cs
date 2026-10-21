using practicaPruebasUnitarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using practicaPruebasUnitarias;

namespace TestPruebasUnitariasApp
{
    [TestClass]
    public class FuncionesTest
    {
        [TestMethod]
        public void EsContrasenyaValida_SiEsNull_DevuelveFalse()
        {
            string contrasenya = null;

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsFalse(resultado, "Una contraseña null debería ser inválida.");
        }

        [TestMethod]
        public void EsContrasenyaValida_SiEstaVacia_DevuelveFalse()
        {
            string contrasenya = "";

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsFalse(resultado, "Una contraseña vacía debería ser inválida.");
        }

        [TestMethod]
        public void EsContrasenyaValida_SiTieneMenosDe8Caracteres_DevuelveFalse()
        {

            string contrasenya = "12345#";

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsFalse(resultado, "Una contraseña con menos de 8 caracteres debería ser inválida.");
        }

        [TestMethod]
        public void EsContrasenyaValida_SiNoTieneAlmohadilla_DevuelveFalse()
        {
            string contrasenya = "12345678";

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsFalse(resultado, "Una contraseña que no contiene '#' debería ser inválida.");
        }

        [TestMethod]
        public void EsContrasenyaValida_SiCumpleTodasLasReglas_DevuelveTrue()
        {
            string contrasenya = "ClaveSegura123#";

            bool resultado = Funciones.EsContrasenyaValida(contrasenya);

            Assert.IsTrue(resultado, "Una contraseña correcta (>=8 caracteres y con '#') debería ser válida.");
        }

    

        [TestMethod]
        public void TestFactorialNegativo()
        {
            Assert.AreEqual(-1, Funciones.CalcularFactorial(-2));
        }

        [TestMethod]
        public void TestFactorialCero()
        {
            Assert.AreEqual(1, Funciones.CalcularFactorial(0));
        }

        [TestMethod]
        public void TestFactorialPositivo()
        {
            Assert.AreEqual(120, Funciones.CalcularFactorial(5));
        }
    }
}