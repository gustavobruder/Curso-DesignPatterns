using System.Collections.Generic;
using System.Linq;
using Solid.Inversao.Dependencia.Common;

namespace Solid.Inversao.Dependencia.Correto
{
    public class Relacoes : IRelacoes
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
                     x.Item2 == Relacao.Pai).Select(r => r.Item3);
        }
    }
}