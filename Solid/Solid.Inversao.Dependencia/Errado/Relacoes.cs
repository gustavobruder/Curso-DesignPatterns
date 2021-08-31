using System.Collections.Generic;
using Solid.Inversao.Dependencia.Common;

namespace Solid.Inversao.Dependencia.Errado
{
    public class Relacoes
    {
        private List<(Pessoa, Relacao, Pessoa)> _relacoes = new List<(Pessoa, Relacao, Pessoa)>();

        public void AdicionarRelacao(Pessoa pai, Pessoa filho)
        {
            _relacoes.Add((pai, Relacao.Pai, filho));
            _relacoes.Add((filho, Relacao.Filho, pai));
        }

        public List<(Pessoa, Relacao, Pessoa)> ObterTodasRelacoes => _relacoes;
    }
}