using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Patterns.Singletons.Aula05
{
    public sealed class ConstrucaoContext : IDisposable
    {
        public int AlturaParede;
        private static Stack<ConstrucaoContext> _stack = new Stack<ConstrucaoContext>();

        static ConstrucaoContext()
        {
            _stack.Push(new ConstrucaoContext(0));
        }

        public ConstrucaoContext(int alturaParede)
        {
            AlturaParede = alturaParede;
            _stack.Push(this);
        }

        public static ConstrucaoContext ContextoAtual => _stack.Peek();

        public void Dispose()
        {
            if (_stack.Count > 1)
                _stack.Pop();
        }
    }

    public class Construcao
    {
        public List<Parede> Paredes = new List<Parede>();

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (var parede in Paredes)
                builder.AppendLine(parede.ToString());
            return builder.ToString();
        }
    }

    public class Parede
    {
        public Ponto Comeco, Fim;
        public int Altura;

        public Parede(Ponto comeco, Ponto fim)
        {
            Comeco = comeco;
            Fim = fim;
            Altura = ConstrucaoContext.ContextoAtual.AlturaParede;
        }

        public override string ToString()
        {
            return $"{nameof(Comeco)}: {Comeco}, {nameof(Fim)}: {Fim}, {nameof(Altura)}: {Altura}";
        }
    }

    public struct Ponto
    {
        public int _x, _y;

        public Ponto(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"X: {_x}, Y: {_y}";
        }
    }
}