using NUnit.Framework;
using System;

namespace Demo_Asserts.Tests
{
    [TestFixture]
    public class DatasEspeciaisStoreTests
    {
        private DatasEspeciaisStore sut;

        [SetUp]
        public void Init()
        {
            sut = new DatasEspeciaisStore();
        }


        [Test]
        public void DeveRetornarCorretamenteAnoNovo()
        {
            var result = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(result, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 0)));
        }

        [Test]
        public void DeveRetornarCorretamenteAnoNovo_Within()
        {
            var result = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(result, Is.EqualTo(new DateTime(2017,1,1,0,0,0,1)).Within(1).Milliseconds);
        }

    }
}
