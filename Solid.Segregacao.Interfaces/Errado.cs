using System;

namespace Solid.Segregacao.Interfaces
{
    public class Errado
    {
        public class Documento
        {
        }
        
        public interface IMaquina
        {
            void Print(Documento d);
            void Scan(Documento d);
            void Fax(Documento d);
        }

        public class MaquinaMultiFuncaoNova : IMaquina
        {
            public void Print(Documento d)
            {
                // Impl
            }

            public void Scan(Documento d)
            {
                // Impl
            }

            public void Fax(Documento d)
            {
                // Impl
            }
        }
        
        public class MaquinaMultiFuncaoObsoleta : IMaquina
        {
            public void Print(Documento d)
            {
                // Impl
            }

            public void Scan(Documento d)
            {
                // Impl
            }

            public void Fax(Documento d)
            {
                // Impl
            }
        }
    }
    
    class ProgramErrado
    {
        static void ExecutarPrincipio()
        {
            Console.WriteLine("Principio da Segragação de Interfaces Errado");
        }
            
        /*static void Main(string[] args)
        {
            ExecutarPrincipio();
        }*/
    }
}