using System;

namespace Solid.Segregacao.Interfaces
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
            Console.WriteLine("\nQuarto Princípio: Segregação de Interfaces!");
        }
    }
}