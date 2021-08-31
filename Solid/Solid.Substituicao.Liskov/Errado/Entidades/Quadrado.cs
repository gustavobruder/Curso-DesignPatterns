namespace Solid.Substituicao.Liskov.Errado.Entidades
{
    public class Quadrado : Retangulo
    {
        public new int Comprimento
        {
            set => base.Comprimento = base.Altura = value;
        }
            
        public new int Altura
        {
            set => base.Comprimento = base.Altura = value;
        }
    }
}