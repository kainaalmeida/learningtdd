using Demo_Asserts;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class JuntarNomesTest
    {
        private JuntarNomes sut;

        [SetUp]
        public void Init()
        {
            sut = new JuntarNomes();
        }

        [Test]
        public void DevoJuntarNomeCompleto()
        {
            var result = sut.Juntar("Kain�", "Almeida");

            Assert.That(result, Is.EqualTo("Kain� Almeida"));
        }

        [Test]
        public void DevoJuntarNomeCompleto_CaseSensitive()
        {
            var result = sut.Juntar("kain�", "almeida");

            Assert.That(result, Is.EqualTo("Kain� Almeida").IgnoreCase);
        }

        [Test]
        public void DevoJuntarNomeCompleto_NaoIgual()
        {
            var result = sut.Juntar("Kain�", "Almeida");

            Assert.That(result, Is.Not.EqualTo("Kain� Fontoura"));
        }

    }
}