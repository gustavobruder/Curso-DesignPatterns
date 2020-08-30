namespace Design.Patterns.Builders.Aula04
{
    public abstract class PessoaBuilder
    {
        protected Pessoa pessoa = new Pessoa();

        public Pessoa Construir()
        {
            return pessoa;
        }
    }
}