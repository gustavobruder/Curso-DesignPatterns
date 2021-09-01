using Autofac;
using Design.Patterns.Singletons.Aula01;
using Design.Patterns.Singletons.Aula02;
using Design.Patterns.Singletons.Common;
using FluentAssertions;
using Xunit;

namespace Design.Patterns.Tests.Singletons
{
    public class SingletonsTests
    {
        [Fact]
        public void Deve_ser_um_singleton()
        {
            var database1 = DatabaseSingleton.Instance;
            var database2 = DatabaseSingleton.Instance;

            database1.Should().BeSameAs(database2);

            DatabaseSingleton.Count.Should().Be(1);
        }

        [Fact]
        public void Deve_obter_total_habitantes_singleton_por_instancia()
        {
            var buscador = new BuscadorRegistrosSingleton();
            var cidades = new[] {"Seoul", "Mexico City"};

            var totalHabitantes = buscador.ObterNumeroTotalHabitantes(cidades);

            totalHabitantes.Should().Be(17500000 + 17400000);
        }

        [Fact]
        public void Deve_conseguir_configurar_um_database()
        {
            var database = new DummyDatabase();
            var buscadorConfiguravel = new BuscadorRegistrosConfiguravel(database);
            var cidades = new[] {"alpha", "gamma"};

            var totalHabitantes = buscadorConfiguravel.ObterTotalHabitantes(cidades);

            totalHabitantes.Should().Be(4);
        }

        [Fact]
        public void Deve_obter_total_habitantes_singleton_por_injecao_dependencia()
        {
            // dependency injection
            var builder = new ContainerBuilder();
            builder.RegisterType<OrdinaryDatabase>().As<IDatabase>().SingleInstance();
            builder.RegisterType<BuscadorRegistrosConfiguravel>();

            using (var container = builder.Build())
            {
                var buscadorConfiguravel = container.Resolve<BuscadorRegistrosConfiguravel>();
                var totalHabitantes = buscadorConfiguravel.ObterTotalHabitantes(new[] {"Delhi", "Jakarta"});
                totalHabitantes.Should().Be(14300000 + 14250000);
            }
        }
    }
}