using System;

namespace Design.Patterns.Singletons
{
    class Program
    {
        static void ExecutarAulas()
        {
            Console.WriteLine("\n----- Aula01 -----");
            // Aula01.Aula01.Executar();

            Console.WriteLine("\n----- Aula02 -----");
            // Aula02.Aula02.Executar();

            Console.WriteLine("\n----- Aula03 -----");
            // Aula03.Aula03.Executar();

            // TODO - Adicionar aulas sobre Singletons
        }

        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nTerceiro Design Pattern: Singletons!");
        }
    }
}