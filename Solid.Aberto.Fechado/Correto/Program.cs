using Solid.Aberto.Fechado.Common;
using Solid.Aberto.Fechado.Correto.Implementacoes;

namespace Solid.Aberto.Fechado.Correto
{
    public class Program
    {
        public static void Executar()
        {
            var arvore = new Produto("Árvore", Cor.Verde, Tamanho.Grande);
            var casa = new Produto("Casa", Cor.Vermelho, Tamanho.Grande);
            var maca = new Produto("Maçã", Cor.Vermelho, Tamanho.Pequeno);

            Produto[] produtos = {arvore, casa, maca};
            
            var filtro = new Filtro();

            var produtosGrandes = filtro.Filtrar(produtos, new TamanhoEspecificacao(Tamanho.Grande));
            Utils.ExibirMensagemDeFiltragem("produtos grandes", produtosGrandes);
            
            var produtosVermelhos = filtro.Filtrar(produtos, new CorEspecificacao(Cor.Vermelho));
            Utils.ExibirMensagemDeFiltragem("produtos vermelhos", produtosVermelhos);
            
            var produtosGrandesVermelhos = filtro.Filtrar(produtos,
                new DoisFiltrosEspecificacao<Produto>(
                    new TamanhoEspecificacao(Tamanho.Grande),
                    new CorEspecificacao(Cor.Vermelho)
                ));
            Utils.ExibirMensagemDeFiltragem("produtos grandes e vermelhos", produtosGrandesVermelhos);
        }
    }
}