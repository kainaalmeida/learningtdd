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
            var result = sut.Juntar("Kainã", "Almeida");

            Assert.That(result, Is.EqualTo("Kainã Almeida"));
        }

        [Test]
        public void DevoJuntarNomeCompleto_CaseSensitive()
        {
            var result = sut.Juntar("kainã", "almeida");

            Assert.That(result, Is.EqualTo("Kainã Almeida").IgnoreCase);
        }

        [Test]
        public void DevoJuntarNomeCompleto_NaoIgual()
        {
            var result = sut.Juntar("Kainã", "Almeida");

            Assert.That(result, Is.Not.EqualTo("Kainã Fontoura"));
        }

    }
}