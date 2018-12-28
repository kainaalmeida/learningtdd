using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Asserts.Tests
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        private CaracteristicasJogador sut;

        [SetUp]
        public void Init()
        {
            sut = new CaracteristicasJogador { Vida = 100 };
        }

        [Test]
        public void DevoAumentarVidaJogadorDepoisDeDormir()
        {
            sut.Dormir();

            Assert.That(sut.Vida, Is.GreaterThan(100));
        }

        #region Intervalo
        [Test]
        public void DevoAumentarVidaJogadorDepoisDeDormir_Intervalo()
        {
            sut.Dormir();

            Assert.That(sut.Vida, Is.InRange(101, 200));
        }
        [Test]
        public void DevoValidarQuePerderVidaAcontecaDeUmEmUm()
        {
            sut.PerderVida(1);

            Assert.That(sut.Vida, Is.InRange(99, 101));
        }
        #endregion

        #region Boleanos e Nulos
        [Test]
        public void DevoValidarSeNomeNaoEhVazio()
        {
            Assert.That(sut.Nome, Is.Not.Empty);
        }

        [Test]
        public void DevoValidarSeNomeNaoEhNulo()
        {
            Assert.That(sut.Nome, Is.Not.Null);
        }

        [Test]
        public void DevoValidarSeApelidoNaoEhNulo()
        {
            Assert.That(sut.Apelido, Is.Not.Null);
        }

        [Test]
        public void DevoValidarNovoJogador()
        {
            Assert.That(sut.Novato, Is.True);
        }
        #endregion

        #region Coleções

        [Test]
        public void NaoDevoTerListaDeArmasVazia()
        {
            Assert.That(sut.Armas, Is.All.Not.Empty);
        }

        [Test]
        public void DeveTerArmaTeiaDeAranha()
        {
            Assert.That(sut.Armas, Contains.Item("Teia de Aranha"));
        }

        [Test]
        public void DeveConterPeloMenosUmTipoDeAI()
        {
            Assert.That(sut.Armas, Has.Some.Contains("Artificial"));
        }

        [Test]
        public void NaoDeveContarArmaVoar()
        {
            Assert.That(sut.Armas, Has.None.EqualTo("Voar"));
        }

        [Test]
        public void DeveConterExatamenteTodasAsArmas()
        {
            var armas = new List<string>()
            {
                "Agilidade",
                "Força",
                "Força e Agilidade",
                "Teia de Aranha",
                "Inteligência Artificial",
                "Escudo",
                "Armadura"
            };

            Assert.That(sut.Armas, Is.EquivalentTo(armas));
        }

        [Test]
        public void ArmasDevemEstarEmOrdemAlfabetica()
        {
            Assert.That(sut.Armas, Is.Ordered);
        }

        #endregion

    }
}
