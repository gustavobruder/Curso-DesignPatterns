using Solid.Aberto.Fechado.Common;
using Solid.Aberto.Fechado.Correto.Interfaces;

namespace Solid.Aberto.Fechado.Correto.Implementacoes
{
    public class CorEspecificacao : IEspecificacao<Produto>
    {
        private Cor _cor;

        public CorEspecificacao(Cor cor)
        {
            _cor = cor;
        }

        public bool Comparar(Produto p)
        {
            return _cor == p.Cor;
        }
    }
}