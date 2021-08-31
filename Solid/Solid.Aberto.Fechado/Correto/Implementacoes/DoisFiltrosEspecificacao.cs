using System;
using Solid.Aberto.Fechado.Correto.Interfaces;

namespace Solid.Aberto.Fechado.Correto.Implementacoes
{
    public class DoisFiltrosEspecificacao<T> : IEspecificacao<T>
    {
        private IEspecificacao<T> _primeiro, _segundo;

        public DoisFiltrosEspecificacao(IEspecificacao<T> primeiro, IEspecificacao<T> segundo)
        {
            _primeiro = primeiro ?? throw new ArgumentNullException(nameof(_primeiro));
            _segundo = segundo ?? throw new ArgumentNullException(nameof(_segundo));
        }

        public bool Comparar(T especificacao)
        {
            return _primeiro.Comparar(especificacao) && _segundo.Comparar(especificacao);
        }
    }
}