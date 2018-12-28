using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Asserts
{
    public class CaracteristicasJogador
    {

        public int Vida { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public bool Novato { get; set; }
        public List<string> Armas { get; set; }

        public CaracteristicasJogador()
        {
            Nome = GerarNome();
            Apelido = "Hero";
            Novato = true;

            CriarArmarIniciais();
        }

        private void CriarArmarIniciais()
        {
            Armas = new List<string>()
            {
                "Agilidade",
                "Força",
                "Força e Agilidade",
                "Teia de Aranha",
                "Inteligência Artificial",
                "Escudo",
                "Armadura"
            }.OrderBy(x => x).ToList();
        }

        private string GerarNome()
        {
            var nomes = new[]
            {
                "Ant-Man",
                "Black-Panter",
                "Capitão",
                "Hulk",
                "Iron-Man",
                "Spider-Man"
            };

            return nomes[new Random().Next(0, nomes.Length)];
        }

        public void Dormir()
        {
            var random = new Random();
            Vida += random.Next(1, 101);
        }

        public void PerderVida(int perderVida)
        {
            Vida = Math.Max(1, Vida -= perderVida);
        }
    }
}
