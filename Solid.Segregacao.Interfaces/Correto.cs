using System;

namespace Solid.Segregacao.Interfaces
{
    public class Correto
    {
        public class Documento
        {
        }

        public interface IPrinter
        {
            void Print(Documento d);
        }
        
        public interface IScanner
        {
            void Scan(Documento d);
        }

        public class Photocopier : IPrinter, IScanner
        {
            public void Print(Documento d)
            {
                // Impl
            }

            public void Scan(Documento d)
            {
                // Impl
            }
        }

        public interface IMaquinaMultiFuncao : IPrinter, IScanner //...
        {
        }

        public class MaquinaMultiFuncao : IMaquinaMultiFuncao
        {
            private IPrinter Printer { get; set; }
            private IScanner Scanner { get; set; }

            public MaquinaMultiFuncao(IPrinter printer, IScanner scanner)
            {
                this.Printer = printer;
                this.Scanner = scanner;
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
    
    class ProgramCorreto
    {
        static void ExecutarPrincipio()
        {
            Console.WriteLine("Principio da Segragação de Interfaces Correto");
        }
            
        static void Main(string[] args)
        {
            ExecutarPrincipio();
        }
    }
}