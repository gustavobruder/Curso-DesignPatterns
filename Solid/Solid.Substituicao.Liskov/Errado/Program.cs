using System;
using Solid.Substituicao.Liskov.Errado.Entidades;

namespace Solid.Substituicao.Liskov.Errado
{
    public class Program
    {
        private static int CalcularArea(Retangulo retangulo) => retangulo.Comprimento * retangulo.Altura;
        
        public static void Executar()
        {
            Retangulo retangulo = new Retangulo(2, 3);
            Console.WriteLine($"{retangulo}, Area: {CalcularArea(retangulo)}");
            
            // Quadrado quadrado = new Quadrado(); // Funciona!
            Retangulo quadrado = new Quadrado();   // NÃO funciona, MAS deveria funcionar!
            quadrado.Comprimento = 4;
            Console.WriteLine($"{quadrado}, Area: {CalcularArea(quadrado)}");
        }
    }
}