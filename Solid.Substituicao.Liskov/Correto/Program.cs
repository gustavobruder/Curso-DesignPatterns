using System;
using Solid.Substituicao.Liskov.Correto.Entidades;

namespace Solid.Substituicao.Liskov.Correto
{
    public class Program
    {
        private static int CalcularArea(Retangulo retangulo) => retangulo.Comprimento * retangulo.Altura;
        
        public static void Executar()
        {
            Retangulo retangulo = new Retangulo(2, 3);
            Console.WriteLine($"{retangulo}, Area: {CalcularArea(retangulo)}");
            
            // Quadrado quadrado = new Quadrado(); // Funciona!
            Retangulo quadrado = new Quadrado();   // Funciona!
            quadrado.Comprimento = 4;
            Console.WriteLine($"{quadrado}, Area: {CalcularArea(quadrado)}");
        }
    }
}