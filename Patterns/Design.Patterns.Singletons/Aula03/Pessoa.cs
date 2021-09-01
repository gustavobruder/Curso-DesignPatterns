namespace Design.Patterns.Singletons.Aula03
{
    public class Pessoa
    {
        private static string _nome;
        private static int _idade;

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public int Idade
        {
            get => _idade;
            set => _idade = value;
        }

        public override string ToString()
        {
            return $"{nameof(Nome)}: {Nome}, {nameof(Idade)}: {Idade}";
        }
    }
}