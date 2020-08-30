using System;
using System.Collections.Generic;

namespace Design.Patterns.Factories.Aula05
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

    // Sem violar o principio SOLID: Aberto-Fechado!
    public class MaquinaDeBebidaQuente
    {
        private List<Tuple<string, IBebidaQuenteFactory>> _factories = new List<Tuple<string, IBebidaQuenteFactory>>();
        
        // Usando reflaction
        public MaquinaDeBebidaQuente()
        {
            foreach (var type in typeof(MaquinaDeBebidaQuente).Assembly.GetTypes())
            {
                if (typeof(IBebidaQuenteFactory).IsAssignableFrom(type) && !type.IsInterface)
                {
                    _factories.Add(Tuple.Create(
                        type.Name.Replace("Factory", string.Empty),
                        (IBebidaQuenteFactory) Activator.CreateInstance(type)
                    ));
                }
            }
        }

        public IBebidaQuente PrepararBebida()
        {
            Console.WriteLine("Bebidas disponíveis: ");
            for (var index = 0; index < _factories.Count; index++)
            {
                var tuple = _factories[index];
                Console.WriteLine($"#{index}: {tuple.Item1}");
            }

            while (true)
            {
                string resposta;
                Console.Write("Selecione uma das bebida: ");

                if ((resposta = Console.ReadLine()) != null && int.TryParse(resposta, out int i) && i >= 0 && i < _factories.Count)
                {
                    Console.Write("Informe a quantidade: ");
                    resposta = Console.ReadLine();
                    
                    if (int.TryParse(resposta, out int quantidade) && quantidade > 0)
                    {
                        Console.WriteLine();
                        return _factories[i].Item2.Preparar(quantidade);
                    }
                }
                Console.WriteLine("\n- Erro, tente novamente!\n");
            }
        }
    }
    
    public class Aula05
    {
        public static void Executar()
        {
            var maquina = new MaquinaDeBebidaQuente();
            
            var bebida = maquina.PrepararBebida();
            bebida.Consumir();
        }
    }
}