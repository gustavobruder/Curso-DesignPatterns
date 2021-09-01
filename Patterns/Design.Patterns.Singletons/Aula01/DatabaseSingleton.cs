using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Design.Patterns.Singletons.Common;

namespace Design.Patterns.Singletons.Aula01
{
    public class DatabaseSingleton : IDatabase
    {
        private Dictionary<string, int> _capitais;

        private static Lazy<DatabaseSingleton> _instance = 
            new Lazy<DatabaseSingleton>(() => new DatabaseSingleton());

        public static DatabaseSingleton Instance => _instance.Value;

        private static int _instanceCount;

        public static int Count => _instanceCount;

        private DatabaseSingleton()
        {
            _instanceCount++;

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