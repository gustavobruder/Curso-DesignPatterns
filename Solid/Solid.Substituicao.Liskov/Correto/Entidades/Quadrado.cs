namespace Solid.Substituicao.Liskov.Correto.Entidades
{
    public class Quadrado : Retangulo
    {
        public override int Comprimento
        {
            set { base.Comprimento = base.Altura = value; }
        }
            
        public override int Altura
        {
            set { base.Comprimento = base.Altura = value; }
        }
    }
}