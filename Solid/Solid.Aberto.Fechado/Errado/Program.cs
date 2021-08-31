using Solid.Aberto.Fechado.Common;

namespace Solid.Aberto.Fechado.Errado
{
    public class Program
    {
        public static void Executar()
        {
            var arvore = new Produto("Árvore", Cor.Verde, Tamanho.Grande);
            var casa = new Produto("Casa", Cor.Vermelho, Tamanho.Grande);
            var maca = new Produto("Maçã", Cor.Vermelho, Tamanho.Pequeno);
           
            Produto[] produtos = {arvore, casa, maca};
            
            var filtro = new FiltroProduto();

            var produtosGrandes = filtro.FiltrarPorTamanho(produtos, Tamanho.Grande);
            Utils.ExibirMensagemDeFiltragem("produtos grandes", produtosGrandes);

            var produtosVermelhos = filtro.FiltrarPorCor(produtos, Cor.Vermelho);
            Utils.ExibirMensagemDeFiltragem("produtos vermelhos", produtosVermelhos);

            var produtosGrandesVermelhos = filtro.FiltrarPorTamanhoECor(produtos, Tamanho.Grande, Cor.Vermelho);
            Utils.ExibirMensagemDeFiltragem("produtos grandes e vermelhos", produtosGrandesVermelhos);
        }
    }
}