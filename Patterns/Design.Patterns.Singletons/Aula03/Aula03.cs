using System;

namespace Design.Patterns.Singletons.Aula03
{
    public class Aula03
    {
        public static void Executar()
        {
            var pessoa1 = new Pessoa();
            pessoa1.Nome = "Gustavo";
            pessoa1.Idade = 18;

            var pessoa2 = new Pessoa();
            Console.WriteLine(pessoa2);
        }
    }
}