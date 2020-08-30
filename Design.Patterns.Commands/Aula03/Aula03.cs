using System;
using Design.Patterns.Commands.Aula03.Commands;
using Design.Patterns.Commands.Aula03.Entidades;

namespace Design.Patterns.Commands.Aula03
{
    public class Aula03
    {
        public static void Executar()
        {
            var contraA = new ContaBancaria();
            contraA.Depositar(100);
            
            var contaB = new ContaBancaria();

            Console.WriteLine("\nRealizando transferência...");
            
            var transferencia = new TransferenciaCommand(contraA, contaB, 100);
            transferencia.ChamarComando();

             Console.WriteLine($"\nConta A => {contraA}");
             Console.WriteLine($"Conta B => {contaB}");
             
             Console.WriteLine("\nDesfazendo transferência...");
             transferencia.DesfazerComando();

             Console.WriteLine($"\nConta A => {contraA}");
             Console.WriteLine($"Conta B => {contaB}");
        }
    }
}