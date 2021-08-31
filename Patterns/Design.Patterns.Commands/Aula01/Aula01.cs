using System;
using System.Collections.Generic;
using Design.Patterns.Commands.Aula01.Commands;
using Design.Patterns.Commands.Aula01.Entidades;
using Design.Patterns.Commands.Common;

namespace Design.Patterns.Commands.Aula01
{
    public class Aula01
    {
        public static void Executar()
        {
            var conta = new ContaBancaria();
            var comandos = new List<ContaBancariaCommand>
            {
                new ContaBancariaCommand(conta, Acao.Depositar, 100),
                new ContaBancariaCommand(conta, Acao.Sacar, 50),
            };

            Console.WriteLine(conta);

            foreach (var comando in comandos)
            {
                comando.ChamarComando();
            }

            Console.WriteLine(conta);
        }
    }
}