using System;
using System.Linq;
using Solid.Inversao.Dependencia.Common;

namespace Solid.Inversao.Dependencia.Errado
{
    public class Program
    {
        private Program(Relacoes relacoes, string pai)
        {
            var relacoesFiltradas = relacoes.ObterTodasRelacoes
                .Where(x => x.Item1.Nome.Equals(pai) && x.Item2 == Relacao.Pai);
            
            foreach (var relacao in relacoesFiltradas)
            {
                Console.WriteLine($"Fulano tem um filho chamado {relacao.Item3.Nome}");
            }
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