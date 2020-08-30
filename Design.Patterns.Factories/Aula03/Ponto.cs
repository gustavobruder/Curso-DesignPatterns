using System;

namespace Design.Patterns.Factories.Aula03
{
    public class Ponto
    {
        private double _x, _y;

        // Construtor private! Apenas 'Factory' tem acesso
        private Ponto(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"Coordenada X = {_x} e Coordenada Y = {_y}";
        }
        
        public static Ponto Origem = new Ponto(0,0);
        
        public static class Factory
        {
            // Inner Factory
            public static Ponto CriarNovoPontoCartesiano(double x, double y)
            {
                return new Ponto(x, y);
            }
        
            // Inner Factory
            public static Ponto CriarNovoPontoPolar(double rho, double theta)
            {
                var x = rho * Math.Cos(theta);
                var y = rho * Math.Sin(theta);
                return new Ponto(x, y);
            }
        }
    }
}