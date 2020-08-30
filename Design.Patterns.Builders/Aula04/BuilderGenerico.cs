using System;

namespace Design.Patterns.Builders.Aula04
{
    public class BuilderGenerico
    {
        public static void Executar()
        {
            var eu = Pessoa.Nova
                .Chamada("Gustavo")
                .TrabalhaComo("Desenvolvedor Jr.")
                .Construir();
            Console.WriteLine(eu);
        }
    }
}