using System.Collections.Generic;
using Solid.Aberto.Fechado.Common;

namespace Solid.Aberto.Fechado.Errado
{
    public class FiltroProduto
    {
        public IEnumerable<Produto> FiltrarPorTamanho(IEnumerable<Produto> produtos, Tamanho tamanho)
        {
            foreach (var produto in produtos)
            {
                if (produto.Tamanho == tamanho)
                {
                    yield return produto;
                }
            }
        }

        public IEnumerable<Produto> FiltrarPorCor(IEnumerable<Produto> produtos, Cor cor)
        {
            foreach (var produto in produtos)
            {
                if (produto.Cor == cor)
                {
                    yield return produto;
                }
            }
        }

        public IEnumerable<Produto> FiltrarPorTamanhoECor(IEnumerable<Produto> produtos, Tamanho tamanho, Cor cor)
        {
            foreach (var produto in produtos)
            {
                if (produto.Tamanho == tamanho && produto.Cor == cor)
                {
                    yield return produto;
                }
            }
        }
    }
}