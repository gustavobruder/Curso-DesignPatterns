using System;
using System.Collections.Generic;

namespace Solid.Aberto.Fechado.Common
{
    public class Utils
    {
        public static void ExibirMensagemDeFiltragem(string mensagem, IEnumerable<Produto> listaFiltrada)
        {
            Console.WriteLine($"\nFiltragem por: {mensagem}");
            foreach (var produto in listaFiltrada)
            {
                Console.WriteLine($"- {produto}");
            }
        }
    }
}