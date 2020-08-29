using System;

namespace Solid.Inversao.Dependencia
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
            Console.WriteLine("\nQuinto Princípio: Inversão de Dependência!");
        } 
    }
}