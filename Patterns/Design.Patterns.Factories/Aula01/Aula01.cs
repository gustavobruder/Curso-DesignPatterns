using System;

namespace Design.Patterns.Factories.Aula01
{
    public class Aula01
    {
        public static void Executar()
        {
            var pontoCartesiano = Ponto.CriarNovoPontoCartesiano(3.0, 4.0);
            Console.WriteLine(pontoCartesiano);
            
            var pontoPolar = Ponto.CriarNovoPontoPolar(1.0, Math.PI / 2);
            Console.WriteLine(pontoPolar);
        }
    }
}