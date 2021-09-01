using System;

namespace Design.Patterns.Singletons.Aula01
{
    public class Aula01
    {
        public static void Executar()
        {
            var database = DatabaseSingleton.Instance;

            var cidade1 = "Tokyo";
            Console.WriteLine($"- {cidade1} tem {database.ObterPopulacao(cidade1)} habitantes.");

            var cidade2 = "Sao Paulo";
            Console.WriteLine($"- {cidade2} tem {database.ObterPopulacao(cidade2)} habitantes.");

            var cidade3 = "Osaka";
            Console.WriteLine($"- {cidade3} tem {database.ObterPopulacao(cidade3)} habitantes.");
        }
    }
}