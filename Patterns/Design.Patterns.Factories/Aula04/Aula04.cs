using System;
using System.Collections.Generic;

namespace Design.Patterns.Factories.Aula04
{
    public interface IBebidaQuente
    {
        void Consumir();
    }

    internal class Cha : IBebidaQuente
    {
        public void Consumir()
        {
            Console.WriteLine("Esse chá está ótimo, porém eu prefiro com leite.");
        }
    }

    internal class Cafe : IBebidaQuente
    {
        public void Consumir()
        {
            Console.WriteLine("Esse café está perfeito!");
        }
    }

    public interface IBebidaQuenteFactory
    {
        IBebidaQuente Preparar(int quantidade);
    }

    internal class ChaFactory : IBebidaQuenteFactory
    {
        public IBebidaQuente Preparar(int quantidade)
        {
            Console.WriteLine($"Coloque num recipiente, água quente, acrescente {quantidade} ml, adicione limão e aproveite!");
            return new Cha();
        }
    }
    
    internal class CafeFactory : IBebidaQuenteFactory
    {
        public IBebidaQuente Preparar(int quantidade)
        {
            Console.WriteLine($"Triure alguns grãos, coloque água quente, acrescente {quantidade} ml, adicione açucar e aproveite!");
            return new Cafe();
        }
    }

    // Violando principio SOLID: Aberto-Fechado!
    public class MaquinaDeBebidaQuente
    {
        public enum BebidasDisponiveis
        {
            Cafe, Cha,
        }
        
        private Dictionary<BebidasDisponiveis, IBebidaQuenteFactory> _factories =
            new Dictionary<BebidasDisponiveis, IBebidaQuenteFactory>();

        public MaquinaDeBebidaQuente()
        {
            foreach (BebidasDisponiveis bebida in Enum.GetValues(typeof(BebidasDisponiveis)))
            {
                var factory = (IBebidaQuenteFactory) Activator.CreateInstance(
                    Type.GetType($"Design.Patterns.Factories.Aula04.{Enum.GetName(typeof(BebidasDisponiveis), bebida)}Factory")
                );
                _factories.Add(bebida, factory);
            }
        }

        public IBebidaQuente PrepararBebida(BebidasDisponiveis bebida, int quantidade)
        {
            return _factories[bebida].Preparar(quantidade);
        }
    }
    
    public class Aula04
    {
        public static void Executar()
        {
            var maquina = new MaquinaDeBebidaQuente();
            
            var cha = maquina.PrepararBebida(MaquinaDeBebidaQuente.BebidasDisponiveis.Cha, 100);
            cha.Consumir();

            Console.WriteLine();
            
            var cafe = maquina.PrepararBebida(MaquinaDeBebidaQuente.BebidasDisponiveis.Cafe, 100);
            cafe.Consumir();
        }
    }
}