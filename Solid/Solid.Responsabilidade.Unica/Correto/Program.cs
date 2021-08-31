using System;

namespace Solid.Responsabilidade.Unica.Correto
{
    public class Program
    {
        public static void Executar()
        {
            var diario = new Diario();
            diario.AdicionarNota("Eu estou felix");
            diario.AdicionarNota("Eu comi um hamburgão");
            Console.WriteLine(diario);

            var persistencia = new Persistencia();
            var arquivo = @"C:\Users\"+ Environment.UserName + @"\Downloads\diario.txt";
            persistencia.CriarArquivoDiario(diario, arquivo, true);
        }
    }
}