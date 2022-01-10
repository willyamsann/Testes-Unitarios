using Calculo;
using System;
using Xunit;

namespace TesteCalculo
{
    public class UnitTest1
    {
        [Fact]
        public void Somar_Double()
        {
            var n1 = 2.5;
            var n2 = 2.4;
            var valorEsperado = 4.9;

            var soma = Calculadora.Somar(n1, n2);
            Assert.Equal(valorEsperado, soma);
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2.5,2.5,5)]
        [InlineData(0,1,1)]
        public void Somar_Double_Theory(double n1, double n2, double valorEsperado)
        {

            var soma = Calculadora.Somar(n1, n2);
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void Subtrair_Double()
        {
            var n1 = 2;
            var n2 = 2;
            var valorEsperado = 0;

            var soma = Calculadora.Subtrair(n1, n2);
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void Multiplicar_Double()
        {
            var n1 = 2;
            var n2 = 2.5;
            var valorEsperado = 5;

            var soma = Calculadora.Mulitplicar(n1, n2);
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void Dividir_Double()
        {
            var n1 = 6;
            var n2 = 2;
            var valorEsperado = 3;

            var soma = Calculadora.Dividir(n1, n2);
            Assert.Equal(valorEsperado, soma);
        }
    }
}
