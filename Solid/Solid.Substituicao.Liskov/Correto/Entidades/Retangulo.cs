namespace Solid.Substituicao.Liskov.Correto.Entidades
{
    public class Retangulo
    {
        public virtual int Comprimento { get; set; }
        public virtual int Altura { get; set; }

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