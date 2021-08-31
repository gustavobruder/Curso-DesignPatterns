using System;

namespace Solid.Aberto.Fechado
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
            Console.WriteLine("\nSegundo Princípio: Aberto-Fechado!");
        } 
    }
}