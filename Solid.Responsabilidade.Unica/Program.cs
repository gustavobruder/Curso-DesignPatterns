using System;

namespace Solid.Responsabilidade.Unica
{
    public class Program
    {
        static void ExecutarPrincipio()
        {
            Console.WriteLine("\n----- Correto -----");
            Correto.Program.Executar();
            
            Console.WriteLine("\n----- Errado -----");
            Errado.Program.Executar();
        }
        
        static void Main(string[] args)
        {
            ExecutarPrincipio();
            Console.WriteLine("\nPrimeiro Princípio: Responsabilidade Única!");
        }
    }
}