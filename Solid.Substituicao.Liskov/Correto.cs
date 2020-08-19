using System;

namespace Solid.Substituicao.Liskov
{
    public class Correto
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
    
    class ProgramCorreto
    {
        public static int Area(Correto.Retangulo retangulo) => retangulo.Comprimento * retangulo.Altura;
        static void ExecutarPrincipio()
        {
            Correto.Retangulo retangulo = new Correto.Retangulo(2, 3);
            Console.WriteLine($"{retangulo}, Area: {Area(retangulo)}");
            
            // Correto.Quadrado quadrado = new Correto.Quadrado(); // FUNCIONA!
            Correto.Retangulo quadrado = new Correto.Quadrado(); // FUNCIONA!
            quadrado.Comprimento = 4;
            Console.WriteLine($"{quadrado}, Area: {Area(quadrado)}");
        }
        
        static void Main(string[] args)
        {
            ExecutarPrincipio();
        }
    }
}