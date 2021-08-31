using Solid.Segregacao.Interfaces.Common;
using Solid.Segregacao.Interfaces.Correto.Interfaces;

namespace Solid.Segregacao.Interfaces.Correto.Implementacoes
{
    public class MaquinaMultiFuncao : IMaquinaMultiFuncao
    {
        private IPrinter Printer { get; set; }
        private IScanner Scanner { get; set; }

        public MaquinaMultiFuncao(IPrinter printer, IScanner scanner)
        {
            Printer = printer;
            Scanner = scanner;
        }

        public void Print(Documento d)
        {
            Printer.Print(d);
        }

        public void Scan(Documento d)
        {
            Scanner.Scan(d);
        }
    }
}