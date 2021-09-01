using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Design.Patterns.Singletons.Common;

namespace Design.Patterns.Singletons.Aula02
{
    public class OrdinaryDatabase : IDatabase
    {
        private Dictionary<string, int> _capitais;

        public OrdinaryDatabase()
        {
            Console.WriteLine("Inicializando database...");

            _capitais = File.ReadAllLines("./Common/capitais.txt")
                .ToChunks(2)
                .ToDictionary(x => x[0], x => int.Parse(x[1]));
        }

        public int ObterPopulacao(string capital)
        {
            return _capitais[capital];
        }
    }
}