using System;

namespace Solid.Aberto.Fechado.Common
{
    public class Produto
    {
        public string Nome { get; set; }
        public Cor Cor { get; set; }
        public Tamanho Tamanho { get; set; }

        public Produto(string nome, Cor cor, Tamanho tamanho)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException(nameof(Nome));
            }
            Nome = nome;
            Cor = cor;
            Tamanho = tamanho;
        }

        public override string ToString()
        {
            return $"{nameof(Nome)}: {Nome.PadRight(6)} | " +
                   $"{nameof(Cor)}: {Cor.ToString().PadRight(8)} | " +
                   $"{nameof(Tamanho)}: {Tamanho.ToString().PadRight(7)} | ";
        }
    }
}