using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.Inversao.Dependencia
{
    public class Errado
    {
        public enum Relacao
        {
            Pai,
            Filho,
            Irmao,
        }

        public class Pessoa
        {
            public string Nome { get; set; }
        }

        public class Relacoes // low-level
        {
            private List<(Pessoa, Relacao, Pessoa)> _relacoes = new List<(Pessoa, Relacao, Pessoa)>();

            public void AdicionarRelacao(Pessoa pai, Pessoa filho)
            {
                _relacoes.Add((pai, Relacao.Pai, filho));
                _relacoes.Add((filho, Relacao.Filho, pai));
            }

            public List<(Pessoa, Relacao, Pessoa)> GetRelacoes => _relacoes;
        }
    }
    
    class ProgramErrado
    {
        public ProgramErrado(Errado.Relacoes relacoes)
        {
            var relacoesObtidas = relacoes.GetRelacoes;
            foreach (var relacao in relacoesObtidas.Where(
                x => x.Item1.Nome.Equals("Fulano") && 
                     x.Item2 == Errado.Relacao.Pai))
            {
                Console.WriteLine($"Fulano tem um filho chamado {relacao.Item3.Nome}");
            }
        }
        
        static void ExecutarPrincipio()
        {
            Console.WriteLine("\nPrincipio da Inversão de Dependência Errado\n");
            
            var pai = new Errado.Pessoa { Nome="Fulano" };
            var filho1 = new Errado.Pessoa { Nome="Ciclano" };
            var filho2 = new Errado.Pessoa { Nome="Beltrano" };
            
            var relacoes = new Errado.Relacoes();
            relacoes.AdicionarRelacao(pai, filho1);
            relacoes.AdicionarRelacao(pai, filho2);

            new ProgramErrado(relacoes);
        }
        
        /*static void Main(string[] args)
        {
            ExecutarPrincipio();
        }*/
    }
}