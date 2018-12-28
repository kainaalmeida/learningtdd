using Calculadora;
using NUnit.Framework;

namespace Tests
{
    public class CalculadoraTest
    {
        [TestFixture]
        public class CalculadoraSimplesTest
        {

            CalculadoraSimples sut;
                   
            [SetUp]
            public void Init()
            {
                sut = new CalculadoraSimples();
            }

            [Test]
            public void DevoAdicionarDoisNumeros()
            {
                var result = sut.Adicionar(5, 5);

                Assert.That(result, Is.EqualTo(10));
            }

            [Test]
            public void DevoMultiplicarDoisNumeros()
            {
                var result = sut.Multiplicar(5, 8);

                Assert.That(result, Is.EqualTo(40));
            }

            [Test]
            public void DevoDividirDoisNumeros()
            {
                var result = sut.Dividir(100,100);

                Assert.That(result, Is.EqualTo(1));
            }

            [Test]
            public void DevoSubtrairDoisNumeros()
            {
                var result = sut.Subtrair(100, 100);

                Assert.That(result, Is.EqualTo(0));
            }
        }
    }
}