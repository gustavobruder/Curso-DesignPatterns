using System;

namespace Design.Patterns.Singletons.Aula05
{
    public class Aula05
    {
        public static void Executar()
        {
            var casa = new Construcao();

            // problema: para cada andar, a altura das paredes é a mesma

            using (new ConstrucaoContext(3000))
            {
                // chao / terreo (3000)
                casa.Paredes.Add(new Parede(new Ponto(0, 0), new Ponto(5000, 0)));
                casa.Paredes.Add(new Parede(new Ponto(0, 0), new Ponto(0, 4000)));

                // primeiro andar (3500)
                using (new ConstrucaoContext(3500))
                {
                    casa.Paredes.Add(new Parede(new Ponto(0, 0), new Ponto(6000, 0)));
                    casa.Paredes.Add(new Parede(new Ponto(0, 0), new Ponto(0, 4000)));
                }

                // chao / terreo (3000)
                casa.Paredes.Add(new Parede(new Ponto(5000, 0), new Ponto(5000, 4000)));
            }

            Console.WriteLine(casa.ToString());
        }
    }
}