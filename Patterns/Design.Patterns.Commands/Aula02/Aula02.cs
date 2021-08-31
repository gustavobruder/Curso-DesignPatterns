using System;
using System.Collections.Generic;
using System.Linq;
using Design.Patterns.Commands.Aula02.Commands;
using Design.Patterns.Commands.Aula02.Entidades;
using Design.Patterns.Commands.Common;

namespace Design.Patterns.Commands.Aula02
{
    public class Aula02
    {
        public static void Executar()
        {
            var conta = new ContaBancaria();
            var comandos = new List<ContaBancariaCommand>
            {
                new ContaBancariaCommand(conta, Acao.Depositar, 100),
                new ContaBancariaCommand(conta, Acao.Sacar, 1000),
            };

            Console.WriteLine(conta);

            foreach (var comando in comandos)
            {
                comando.ChamarComando();
            }

            Console.WriteLine(conta);
            
            foreach (var comando in Enumerable.Reverse(comandos))
            {
                comando.DesfazerComando();
            }
            
            Console.WriteLine(conta);
        }
    }
}