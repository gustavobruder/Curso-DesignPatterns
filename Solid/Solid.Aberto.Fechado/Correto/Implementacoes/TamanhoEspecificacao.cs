using Solid.Aberto.Fechado.Common;
using Solid.Aberto.Fechado.Correto.Interfaces;

namespace Solid.Aberto.Fechado.Correto.Implementacoes
{
    public class TamanhoEspecificacao : IEspecificacao<Produto>
    {
        private Tamanho _tamanho;

        public TamanhoEspecificacao(Tamanho tamanho)
        {
            _tamanho = tamanho;
        }

        public bool Comparar(Produto p)
        {
            return _tamanho == p.Tamanho;
        }
    }
}