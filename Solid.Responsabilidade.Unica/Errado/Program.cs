using System;

namespace Solid.Responsabilidade.Unica.Errado
{
    public class Program
    {
        public static void Executar()
        {
            var diario = new Diario();
            diario.AdicionarNota("Eu estou felix");
            diario.AdicionarNota("Eu comi um hamburgão");
            Console.WriteLine(diario);
            
            var arquivo = @"C:\Users\"+ Environment.UserName + @"\Downloads\diario.txt";
            diario.CriarArquivo(arquivo, true);
        }
    }
}