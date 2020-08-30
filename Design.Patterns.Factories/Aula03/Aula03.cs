using System;

namespace Design.Patterns.Factories.Aula03
{
    public class Aula03
    {
        public static void Executar()
        {
            var pontoA = Ponto.Factory.CriarNovoPontoCartesiano(3.0, 4.0);
            var pontoB = Ponto.Factory.CriarNovoPontoPolar(1.0, Math.PI / 2);
            var origem = Ponto.Origem;
            
            Console.WriteLine($"Ponto A = {pontoA}");
            Console.WriteLine($"Ponto B = {pontoB}");
            Console.WriteLine($"Origem = {origem}");
        }
    }
}