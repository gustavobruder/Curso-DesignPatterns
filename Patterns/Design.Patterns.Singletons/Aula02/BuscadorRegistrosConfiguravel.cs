using System;
using System.Collections.Generic;
using System.Linq;
using Design.Patterns.Singletons.Common;

namespace Design.Patterns.Singletons.Aula02
{
    public class BuscadorRegistrosConfiguravel
    {
        private readonly IDatabase _database;

        public BuscadorRegistrosConfiguravel(IDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(paramName: nameof(database));
        }

        public int ObterTotalHabitantes(IEnumerable<string> capitais)
        {
            return capitais.Sum(capital => _database.ObterPopulacao(capital));
        }
    }
}