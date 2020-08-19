using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.Inversao.Dependencia
{
    public class Correto
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

        public interface IRelacao
        {
            IEnumerable<Pessoa> ObterTodasCriancasDe(string nome);
        }

        public class Relacoes : IRelacao // low-level
        {
            private List<(Pessoa, Relacao, Pessoa)> _relacoes = new List<(Pessoa, Relacao, Pessoa)>();

            public void AdicionarRelacao(Pessoa pai, Pessoa filho)
            {
                _relacoes.Add((pai, Relacao.Pai, filho));
                _relacoes.Add((filho, Relacao.Filho, pai));
            }

            public IEnumerable<Pessoa> ObterTodasCriancasDe(string nome)
            {
                return _relacoes.Where(
                    x => x.Item1.Nome.Equals(nome) && 
                         x.Item2 == Correto.Relacao.Pai).Select(r => r.Item3);
            }
        }
    }
    
    class ProgramCorreto
    {
        public ProgramCorreto(Correto.IRelacao relacao)
        {
            foreach (var pessoa in relacao.ObterTodasCriancasDe("Fulano"))
                Console.WriteLine($"Fulano tem um filho chamado {pessoa.Nome}");
        }
        
        static void ExecutarPrincipio()
        {
            Console.WriteLine("\nPrincipio da Inversão de Dependência Errado\n");
            
            var pai = new Correto.Pessoa { Nome="Fulano" };
            var filho1 = new Correto.Pessoa { Nome="Ciclano" };
            var filho2 = new Correto.Pessoa { Nome="Beltrano" };
            
            var relacoes = new Correto.Relacoes();
            relacoes.AdicionarRelacao(pai, filho1);
            relacoes.AdicionarRelacao(pai, filho2);

            new ProgramCorreto(relacoes);
        }
        
        static void Main(string[] args)
        {
            ExecutarPrincipio();
        }
    }
}