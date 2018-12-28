using NUnit.Framework;
using System;

namespace Demo_Asserts.Tests
{
    [TestFixture]
    public class CalculadoraTests
    {
        private Calculadora sut;

        [SetUp]
        public void Init()
        {
            sut = new Calculadora();
        }

        #region Operações Básicas
        [Test]
        public void DevoSomarNumerosInteiros()
        {
            var result = sut.SomarInteiros(4, 2);

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void DevoSomarNumerosDecimais_Within()
        {
            var result = sut.SomarDecimais(1.1, 2.2);

            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithinPorcentagem()
        {
            var result = sut.SomarDecimais(50, 50);

            Assert.That(result, Is.EqualTo(101).Within(1).Percent);
        }

        #endregion


        #region Tratando Exceptions

        [Test]
        public void DeveRetornarErroQuandoDividirPorNumeroMaiorQueCem()
        {
            Assert.That(() => sut.Dividir(200, 1), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void DeveRetornarErroQuandoDividirPorZero_Ex1()
        {
            //var result = sut.Dividir(99, 0);
            Assert.That(() => sut.Dividir(99, 0), Is.Positive);
        }

        #endregion

    }
}
