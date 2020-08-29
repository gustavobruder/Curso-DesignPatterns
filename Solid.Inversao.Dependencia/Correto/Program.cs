using System;
using Solid.Inversao.Dependencia.Common;

namespace Solid.Inversao.Dependencia.Correto
{
    public class Program
    {
        private Program(IRelacoes relacoes, string pai)
        {
            foreach (var pessoa in relacoes.ObterTodasCriancasDe(pai))
                Console.WriteLine($"Fulano tem um filho chamado {pessoa.Nome}");
        }

        public static void Executar()
        {
            var pai = new Pessoa { Nome = "Fulano" };
            var filho1 = new Pessoa { Nome = "Ciclano" };
            var filho2 = new Pessoa { Nome = "Beltrano" };
            
            var relacoes = new Relacoes();
            relacoes.AdicionarRelacao(pai, filho1);
            relacoes.AdicionarRelacao(pai, filho2);

            new Program(relacoes, pai.Nome);
        }
    }
}