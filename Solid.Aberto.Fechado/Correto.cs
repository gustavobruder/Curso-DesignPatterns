using System;
using System.Collections.Generic;

namespace Solid.Aberto.Fechado
{
    public class Correto
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
    }
    
    public interface IEspecificacao<T>
    {
        bool IsSatisfied(T especificacao);
    }

    public interface IFiltro<T>
    {
        IEnumerable<T> Filtrar(IEnumerable<T> itens, IEspecificacao<T> especificacao);
    }
    
    public class CorEspecificacao : IEspecificacao<Correto.Produto>
    {
        private Correto.Cor Cor;

        public CorEspecificacao(Correto.Cor cor)
        {
            Cor = cor;
        }

        public bool IsSatisfied(Correto.Produto p)
        {
            return p.Cor == Cor;
        }
    }
    
    public class TamanhoEspecificacao : IEspecificacao<Correto.Produto>
    {
        private Correto.Tamanho Tamanho;

        public TamanhoEspecificacao(Correto.Tamanho tamanho)
        {
            Tamanho = tamanho;
        }

        public bool IsSatisfied(Correto.Produto p)
        {
            return p.Tamanho == Tamanho;
        }
    }

    public class EEspecificacao<T> : IEspecificacao<T>
    {
        private IEspecificacao<T> _primeiro, _segundo;

        public EEspecificacao(IEspecificacao<T> primeiro, IEspecificacao<T> segundo)
        {
            _primeiro = primeiro ?? throw new ArgumentNullException(nameof(_primeiro));
            _segundo = segundo ?? throw new ArgumentNullException(nameof(_segundo));
        }

        public bool IsSatisfied(T especificacao)
        {
            return _primeiro.IsSatisfied(especificacao) && _segundo.IsSatisfied(especificacao);
        }
    }

    public class Filtro : IFiltro<Correto.Produto>
    {
        public IEnumerable<Correto.Produto> Filtrar(IEnumerable<Correto.Produto> itens, IEspecificacao<Correto.Produto> especificacao)
        {
            foreach (var item in itens)
            {
                if (especificacao.IsSatisfied(item))
                {
                    yield return item;
                }
            }
        }
    }

    public class ProgramCorreto
    {
        static void ExecutarPrincipio()
        {
            var arvore = new Correto.Produto("Árvore", Correto.Cor.Verde, Correto.Tamanho.Grande);
            var casa = new Correto.Produto("Casa", Correto.Cor.Vermelho, Correto.Tamanho.Grande);
            var maca = new Correto.Produto("Maçã", Correto.Cor.Vermelho, Correto.Tamanho.Pequeno);

            Correto.Produto[] produtos = {arvore, casa, maca};
          
            Console.WriteLine("\nProdutos grandes: ");
            var filtro = new Filtro();
            foreach (var produto in filtro.Filtrar(produtos, new TamanhoEspecificacao(Correto.Tamanho.Grande)))
            {
                Console.WriteLine($"- {produto.Nome} é grande");
            }
            
            Console.WriteLine("\nProdutos vermelhos: ");
            foreach (var produto in filtro.Filtrar(produtos, new CorEspecificacao(Correto.Cor.Vermelho)))
            {
                Console.WriteLine($"- {produto.Nome} é vermelho");
            }
            
            Console.WriteLine("\nProdutos grandes e vermelhos: ");
            foreach (var produto in filtro.Filtrar(produtos,
                new EEspecificacao<Correto.Produto>(
                new TamanhoEspecificacao(Correto.Tamanho.Grande),
                new CorEspecificacao(Correto.Cor.Vermelho)
                )))
            {
                Console.WriteLine($"- {produto.Nome} é grande e vermelho");
            }
        }
        
        static void Main(string[] args)
        {
            ExecutarPrincipio();
        }
    }
}