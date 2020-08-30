using System;
using Design.Patterns.Builders.Aula01;
using Design.Patterns.Builders.Aula02;
using Design.Patterns.Builders.Aula03;
using Design.Patterns.Builders.Aula04;

namespace Design.Patterns.Builders
{
    class Program
    {
        static void ExecutarAulas()
        {
            Console.WriteLine("\n----- Aula01 -----");
            SemBuilder.Executar();
            
            Console.WriteLine("\n----- Aula02 -----");
            ComBuilder.Executar();
            
            Console.WriteLine("\n----- Aula03 -----");
            FluentBuilder.Executar();
            
            Console.WriteLine("\n----- Aula04 -----");
            BuilderGenerico.Executar();
            
            // TODO - Adicionar Aula05: Functional Builder
            
            // TODO - Adicionar Aula06: Faceted Builder
        }
        
        static void Main(string[] args)
        {
            ExecutarAulas();
            Console.WriteLine("\nPrimeiro Design Pattern: Builders!");
        }
    }
}