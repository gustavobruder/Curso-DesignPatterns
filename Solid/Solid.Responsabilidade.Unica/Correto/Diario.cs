using System;
using System.Collections.Generic;

namespace Solid.Responsabilidade.Unica.Correto
{
    public class Diario
    {
        private readonly List<string> _notas = new List<string>();

        private static int _contador = 0;

        public int AdicionarNota(string nota)
        {
            _notas.Add($"{++_contador}: {nota}");
            return _contador;
        }
        
        public void RemoverNota(int indice)
        {
            _notas.RemoveAt(indice);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _notas);
        }
    }
}