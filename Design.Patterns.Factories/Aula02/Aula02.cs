using System;

namespace Design.Patterns.Factories.Aula02
{
    public class Aula02
    {
        public static async void Executar()
        {
            var foo = await Foo.Criar();
            Console.WriteLine($"Async Factory: {foo}");
        }
    }
}