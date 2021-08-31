using System.Threading.Tasks;

namespace Design.Patterns.Factories.Aula02
{
    public class Foo
    {
        private Foo()
        {
            // Params...
        }
        
        private async Task<Foo> Iniciar()
        {
            await Task.Delay(0);
            return this;
        }
        
        // Async Factory
        public static Task<Foo> Criar()
        {
            var resultado = new Foo();
            return resultado.Iniciar();
        }
    }
}