using Solid.Segregacao.Interfaces.Common;

namespace Solid.Segregacao.Interfaces.Errado.Interfaces
{
    public interface IMaquina
    {
        void Print(Documento d);
        void Scan(Documento d);
        void Fax(Documento d);
    }
}