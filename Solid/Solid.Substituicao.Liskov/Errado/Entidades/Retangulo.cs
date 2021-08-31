namespace Solid.Substituicao.Liskov.Errado.Entidades
{
    public class Retangulo
    {
        public int Comprimento { get; set; }
        public int Altura { get; set; }

        public Retangulo()
        {
        }

        public Retangulo(int comprimento, int altura)
        {
            Comprimento = comprimento;
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{nameof(Comprimento)}: {Comprimento}, {nameof(Altura)}: {Altura}";
        }
    }
}