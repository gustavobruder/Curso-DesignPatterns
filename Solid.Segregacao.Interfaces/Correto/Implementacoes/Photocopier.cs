using System;
using Solid.Segregacao.Interfaces.Common;
using Solid.Segregacao.Interfaces.Correto.Interfaces;

namespace Solid.Segregacao.Interfaces.Correto.Implementacoes
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Documento d)
        {
            // Impl...
        }

        public void Scan(Documento d)
        {
            // Impl...
        }
    }
}