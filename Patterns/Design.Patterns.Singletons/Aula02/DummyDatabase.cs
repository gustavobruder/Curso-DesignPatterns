using System.Collections.Generic;
using Design.Patterns.Singletons.Common;

namespace Design.Patterns.Singletons.Aula02
{
    public class DummyDatabase : IDatabase
    {
        public int ObterPopulacao(string capital)
        {
            return new Dictionary<string, int>
            {
                ["alpha"] = 1,
                ["beta"] = 2,
                ["gamma"] = 3
            }[capital];
        }
    }
}