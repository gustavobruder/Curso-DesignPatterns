using System.Collections.Generic;
using Solid.Inversao.Dependencia.Common;

namespace Solid.Inversao.Dependencia.Correto
{
    public interface IRelacoes
    {
        IEnumerable<Pessoa> ObterTodasCriancasDe(string nome);
    }
}