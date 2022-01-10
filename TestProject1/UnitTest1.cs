using Calculo;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SomaDouble()
        {
            var result = Calculadora.Somar(1, 2);

            Assert.AreEqual(3,result);
        }

        [TestCase(1,2,3)]
        public void SomaDoubleTestCase(double n1, double n2, double esperado)
        {
            var result = Calculadora.Somar(n1, n2);

            Assert.AreEqual(esperado, result);
        }
    }
}