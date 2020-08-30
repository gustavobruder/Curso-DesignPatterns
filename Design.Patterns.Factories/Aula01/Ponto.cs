using System;

namespace Design.Patterns.Factories.Aula01
{
    public class Ponto
    {
        private double _x, _y;

        private Ponto(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"Coordenada X = {_x} e Coordenada Y = {_y}";
        }

        // Factory
        public static Ponto CriarNovoPontoCartesiano(double x, double y)
        {
            return new Ponto(x, y);
        }
        
        // Factory
        public static Ponto CriarNovoPontoPolar(double rho, double theta)
        {
            var x = rho * Math.Cos(theta);
            var y = rho * Math.Sin(theta);
            return new Ponto(x, y);
        }
    }
}