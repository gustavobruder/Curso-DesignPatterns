﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Solid.Responsabilidade.Unica
{
    public class Correto
    {
        public class DiarioCorreto
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

        public class Persistencia
        {
            public void CriarArquivoDiario(DiarioCorreto diario, string arquivo, bool overwrite = false)
            {
                if (overwrite || !File.Exists(arquivo))
                {
                    File.WriteAllText(arquivo, diario.ToString());
                }
            }
        }
    }
    
    class ProgramCorreto
    {
        static void ExecutarPrincipio()
        {
            var diario = new Correto.DiarioCorreto();
            diario.AdicionarNota("Eu estou felix");
            diario.AdicionarNota("Eu comi um hamburgão");
            Console.WriteLine(diario);

            var persistencia = new Correto.Persistencia();
            var arquivo = @"C:\Users\"+ Environment.UserName + @"\Downloads\diario.txt";
            persistencia.CriarArquivoDiario(diario, arquivo, true);
        }
        
        static void Main(string[] args)
        {
            ExecutarPrincipio();   
        }
    }
}