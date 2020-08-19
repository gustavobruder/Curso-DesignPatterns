using System;

namespace Solid.Substituicao.Liskov
{
    public class Errado
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
        
        public class Quadrado : Retangulo
        {
            public new int Comprimento
            {
                set { base.Comprimento = base.Altura = value; }
            }
            
            public new int Altura
            {
                set { base.Comprimento = base.Altura = value; }
            }
        }
    }
    
    class ProgramErrado
    {
        public static int Area(Errado.Retangulo retangulo) => retangulo.Comprimento * retangulo.Altura;
        static void ExecutarPrincipio()
        {
            Errado.Retangulo retangulo = new Errado.Retangulo(2, 3);
            Console.WriteLine($"{retangulo}, Area: {Area(retangulo)}");
            
            // Errado.Quadrado quadrado = new Errado.Quadrado(); // FUNCIONA!
            Errado.Retangulo quadrado = new Errado.Quadrado(); // NÃO FUNCIONA, MAS DEVERIA FUNCIONAR!
            quadrado.Comprimento = 4;
            Console.WriteLine($"{quadrado}, Area: {Area(quadrado)}");
        }
        
        /*static void Main(string[] args)
        {
            ExecutarPrincipio();
        }*/
    }
}