using System;

namespace Design.Patterns.Singletons.Aula02
{
    public class Aula02
    {
        public static void Executar()
        {
            var database = new DummyDatabase();
            var buscadorConfiguravel = new BuscadorRegistrosConfiguravel(database);
            var cidades = new[] {"alpha", "gamma"};

            var totalHabitantes = buscadorConfiguravel.ObterTotalHabitantes(cidades);

            Console.WriteLine($"- {cidades[0]} tem {database.ObterPopulacao(cidades[0])} habitantes.");
            Console.WriteLine($"- {cidades[1]} tem {database.ObterPopulacao(cidades[1])} habitantes.");
            Console.WriteLine($"- Total de habitantes é {totalHabitantes}.");
        }
    }
}