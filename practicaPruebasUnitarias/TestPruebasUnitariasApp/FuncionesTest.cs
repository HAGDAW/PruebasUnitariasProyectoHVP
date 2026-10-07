using practicaPruebasUnitarias;

namespace TestPruebasUnitariasApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
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
