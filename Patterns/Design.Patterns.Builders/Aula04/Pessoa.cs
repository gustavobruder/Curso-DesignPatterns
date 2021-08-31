namespace Design.Patterns.Builders.Aula04
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Trabalho { get; set; }

        public class Construtor : PessoaTrabalhoBuilder<Construtor>
        {
        }
        
        public static Construtor Nova => new Construtor();

        public override string ToString()
        {
            return $"{nameof(Nome)}: {Nome}, {nameof(Trabalho)}: {Trabalho}";
        }
    }
}