using System.Collections.Generic;
using System.Linq;

namespace Design.Patterns.Singletons.Aula01
{
    public class BuscadorRegistrosSingleton
    {
        public int ObterNumeroTotalHabitantes(IEnumerable<string> registros)
        {
            return registros.Sum(registro => DatabaseSingleton.Instance.ObterPopulacao(registro));
        }
    }
}