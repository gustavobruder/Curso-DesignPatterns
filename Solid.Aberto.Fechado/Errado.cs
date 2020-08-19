using System;
using System.Collections.Generic;

namespace Solid.Aberto.Fechado
{
    public class Errado
    {
        public enum Cor
        {
            Vermelho, Verde, Azul 
        }
        
        public enum Tamanho
        {
            Pequeno, Medio, Grande
        }
        
        public class Produto
        {
            public string Nome { get; set; }
            public Cor Cor { get; set; }
            public Tamanho Tamanho { get; set; }

            public Produto(string nome, Cor cor, Tamanho tamanho)
            {
                if (String.IsNullOrEmpty(nome))
                {
                    throw new ArgumentNullException(nameof(Nome));
                }
                Nome = nome;
                Cor = cor;
                Tamanho = tamanho;
            }
        }
        
        public class FiltroProduto
        {
            public IEnumerable<Produto> FiltrarPorTamanho(
                IEnumerable<Produto> produtos, Tamanho tamanho)
            {
                foreach (var produto in produtos)
                {
                    if (produto.Tamanho == tamanho)
                    {
                        yield return produto;
                    }
                }
            }
            
            public IEnumerable<Produto> FiltrarPorCor(
                IEnumerable<Produto> produtos, Cor cor)
            {
                foreach (var produto in produtos)
                {
                    if (produto.Cor == cor)
                    {
                        yield return produto;
                    }
                }
            }
            
            public IEnumerable<Produto> FiltrarPorTamanhoECor(
                IEnumerable<Produto> produtos, Tamanho tamanho, Cor cor)
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

    public class ProgramErrado
    {
        static void ExecutarPrincipio()
        {
            var arvore = new Errado.Produto("Árvore", Errado.Cor.Verde, Errado.Tamanho.Grande);
            var casa = new Errado.Produto("Casa", Errado.Cor.Vermelho, Errado.Tamanho.Grande);
            var maca = new Errado.Produto("Maçã", Errado.Cor.Vermelho, Errado.Tamanho.Pequeno);

            Errado.Produto[] produtos = {arvore, casa, maca};
            var filtro = new Errado.FiltroProduto();
            Console.WriteLine("\nProdutos grandes: ");
            foreach (var produto in filtro.FiltrarPorTamanho(produtos, Errado.Tamanho.Grande))
            {
                Console.WriteLine($"- {produto.Nome} é grande");
            }
            
            Console.WriteLine("\nProdutos vermelhos: ");
            foreach (var produto in filtro.FiltrarPorCor(produtos, Errado.Cor.Vermelho))
            {
                Console.WriteLine($"- {produto.Nome} é vermelho");
            }
            
            Console.WriteLine("\nProdutos grandes e vermelhos: ");
            foreach (var produto in filtro.FiltrarPorTamanhoECor(produtos, Errado.Tamanho.Grande, Errado.Cor.Vermelho))
            {
                Console.WriteLine($"- {produto.Nome} é grande e vermelho");
            }
        }
        
        /*static void Main(string[] args)
        {
            ExecutarPrincipio();
        }*/
    }
}